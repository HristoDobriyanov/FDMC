using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.App.Models.BindingModels;
using FDMC.App.Models.ViewModels;
using FDMC.Data;
using FDMC.Models;
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
            var catModel = new CatDetailsViewModel()
            {
                Age = cat.Age,
                Breed = cat.Breed,
                ImageUrl = cat.ImageUrl,
                Name = cat.Name
            };

            

            return View(model: catModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(CatCreatingBindingModel model)
        {
            var cat = new Cat()
            {
                Age = model.Age,
                Breed = model.Breed,
                ImageUrl = model.ImageUrl,
                Name = model.Name
            };
            this.Context.Cats.Add(cat);
            this.Context.SaveChanges();

            //return RedirectToRoute(
            //    "default",
            //    new { controller = "Cats", Action = "Details", Id = model.Id });

            return RedirectToAction("Details", new {id=cat.Id});
        }
    }
}