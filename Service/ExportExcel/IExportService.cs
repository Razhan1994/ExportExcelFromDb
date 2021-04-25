using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ExportExcel
{
    public interface IExportService
    {
        Task<string> ExportExcel();
    }
}
