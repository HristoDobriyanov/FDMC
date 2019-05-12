using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using Microsoft.AspNetCore.Mvc;
using FDMC.Models;
using FDMC.Web.ViewModels;

namespace FDMC.Controllers
{
    public class HomeController : Controller
    {
        private FdmcDbContext dbContext;

        public HomeController(FdmcDbContext dbContext)
        {
            this.dbContext = dbContext;
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
