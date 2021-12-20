using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class MotherboardsController : Controller
    {
        private readonly DataManager dataManager;

        public MotherboardsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Motherboards.GetMotherboardById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <-- ? менять ли для моделей (Добавляет название окну)
            return View(dataManager.Motherboards.GetMotherboards());
        }
    }
}
