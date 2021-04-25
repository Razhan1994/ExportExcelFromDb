using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service.ExportExcel;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;

namespace Service.Main
{
    public class MainService : IMainService
    {
        private readonly IExportService _exportService;
        public MainService(IExportService exportService)
        {
            _exportService = exportService;
        }
        public async Task<string> GetUserListExcel()
        {
            // Lets converts our object data to Datatable for a simplified logic.
            // Datatable is most easy way to deal with complex datatypes for easy reading and formatting.
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject("ModelFromDB"), (typeof(DataTable)));
            table.Columns["OldNameOfField"].ColumnName = "NewNameOfField";

            string link = await _exportService.ExportExcel(table, "folder-name", "output-name", new List<string>());

            return link;
        }
    }
}
