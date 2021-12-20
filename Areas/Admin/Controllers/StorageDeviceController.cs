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
    public class StorageDevicesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public StorageDevicesController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(dataManager.StorageDevices.GetStorageDevices());
        }
        public IActionResult Edit(Guid id)
        {
            var item = id == default ? new StorageDevice() : dataManager.StorageDevices.GetStorageDeviceById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(StorageDevice model, IFormFile titleImageFile)
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
                dataManager.StorageDevices.SaveStorageDevice(model);
                return RedirectToAction(nameof(StorageDevicesController.Index), nameof(StorageDevicesController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.StorageDevices.DeleteStorageDevice(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
