using ExportExcelFromDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExportExcelFromDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainService _mainService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            IMainService mainService)
        {
            _logger = logger;
            _mainService = mainService;
        }

        public async Task<IActionResult> ExportExcel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetExcelLink()
        {
            string link = await _mainService.GetUserListExcel();
            return Json(link);
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
