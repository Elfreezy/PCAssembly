using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SoundCardsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public SoundCardsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(dataManager.SoundCards.GetSoundCards());
        }
        public IActionResult Edit(Guid id)
        {
            var item = id == default ? new SoundCard() : dataManager.SoundCards.GetSoundCardById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(SoundCard model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "img/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                else if (!(model.TitleImagePath != null))
                {
                    model.TitleImagePath = "zero.png";
                }
                dataManager.SoundCards.SaveSoundCard(model);
                return RedirectToAction(nameof(SoundCardsController.Index), nameof(SoundCardsController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.SoundCards.DeleteSoundCard(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
