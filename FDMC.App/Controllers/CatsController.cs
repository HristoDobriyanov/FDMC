using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.App.Controllers
{
    public class CatsController : Controller
    {

        public CatsController(FDMCAppDbContext context)
        {
            this.Context = context;
        }

        public FDMCAppDbContext Context { get; set; }

        public IActionResult Details(int id)
        {
            var cat = this.Context.Cats.Find(id);

            if (cat == null)
            {
                return NotFound();
            }

            return View(model: cat);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPut]
        public IActionResult Add(object model)
        {
            var cat = model;
            return this.View();
        }
    }
}