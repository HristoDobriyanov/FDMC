using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FDMC.App.Models;
using FDMC.App.Models.ViewModels;
using FDMC.Data;

namespace FDMC.App.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(FDMCAppDbContext context)
        {
            this.Context = context;
        }

        public FDMCAppDbContext Context { get; private set; }

        public IActionResult Index()
        {
            var cats = this.Context.Cats
                .Select(cat => new CatConciseViewModel()
                {
                    Id = cat.Id,
                    Name = cat.Name
                })
                .ToArray();

            return View(cats);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
