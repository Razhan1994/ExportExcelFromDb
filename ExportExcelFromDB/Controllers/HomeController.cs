using ExportExcelFromDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.ExportExcel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExportExcelFromDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExportService _exportService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            IExportService exportService)
        {
            _logger = logger;
            _exportService = exportService;
        }

        public async Task<IActionResult> ExportExcel()
        {
            string link = await _exportService.ExportExcel();
            return View(link);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
