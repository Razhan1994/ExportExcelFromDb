using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ExportExcel
{
    public interface IExportService
    {
        Task<string> ExportExcel(DataTable table, string folderName, string outputName, List<string> IgnoreStrings);
    }
}
