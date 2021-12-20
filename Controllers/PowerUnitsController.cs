using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class PowerUnitsController : Controller
    {
        private readonly DataManager dataManager;

        public PowerUnitsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.PowerUnits.GetPowerUnitById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?
            return View(dataManager.PowerUnits.GetPowerUnits());
        }
    }
}
