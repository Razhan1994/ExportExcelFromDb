using Microsoft.Extensions.Hosting;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Service.ExportExcel
{
    public class ExportService : IExportService
    {
        private IHostingEnvironment _hostingEnvironment;
        public ExportService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<string> ExportExcel(DataTable table, string folderName, string outputName, List<string> IgnoreStrings)
        {
            string sWebRootFolder = _hostingEnvironment.ContentRootPath;

            //add date and time to the end of output link name
            string sFileName = "ReportsInExcel/" + folderName + "/" + outputName.Replace(":", "-") + " - "
                + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "-").Replace(":", "-").Replace("/", "-")
                + ".xlsx";

            string path = Path.Combine(sWebRootFolder, sFileName);

            string filePath = Path.Combine(sWebRootFolder, "ReportsInExcel/" + folderName);
            if (Directory.Exists(filePath))
                Directory.Delete(filePath, true);

            Directory.CreateDirectory(filePath);

            var memoryStream = new MemoryStream();

            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet(outputName.Replace(":", "-"));

                List<String> columns = new List<string>();
                IRow row = excelSheet.CreateRow(0);
                int columnIndex = 0;

                foreach (System.Data.DataColumn column in table.Columns)
                {
                    if (IgnoreStrings.Any(x => x.ToLower() == column.ColumnName.ToLower()))
                        continue;

                    columns.Add(column.ColumnName);
                    row.CreateCell(columnIndex).SetCellValue(column.ColumnName);
                    columnIndex++;
                }

                int rowIndex = 1;
                foreach (DataRow dsrow in table.Rows)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    int cellIndex = 0;
                    foreach (String col in columns)
                    {
                        row.CreateCell(cellIndex).SetCellValue(dsrow[col].ToString());
                        cellIndex++;
                    }

                    rowIndex++;
                }
                workbook.Write(fs);
            }
            return sFileName;

        }
    }
}
