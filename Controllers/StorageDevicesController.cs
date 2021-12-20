using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class StorageDevicesController : Controller
    {
        private readonly DataManager dataManager;

        public StorageDevicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.StorageDevices.GetStorageDeviceById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?
            return View(dataManager.StorageDevices.GetStorageDevices());
        }
    }
}
