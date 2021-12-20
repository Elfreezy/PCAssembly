using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly DataManager dataManager;

        public ComponentsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Components.GetComponentById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?
            return View(dataManager.Components.GetComponents());
        }
        public IActionResult ChooseProcessor()
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?
            return View(dataManager.Processors.GetProcessors());
        }

        [HttpPost]
        public IActionResult ChooseMotherboard(string processorId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (processorId != null)
            {
                Response.Cookies.Append("ProcessorId", processorId);
                return View(dataManager.Motherboards.GetMotherboardsBySocket(new Guid(processorId)));
            }
            return View(dataManager.Motherboards.GetMotherboards());
        }

        [HttpPost]
        public IActionResult ChooseVideoadapter(string motherboardId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (motherboardId != null)
            {
                Response.Cookies.Append("MotherboardId", motherboardId);
                return View(dataManager.Videoadapters.GetVideoadaptersBySocket(new Guid(motherboardId)));
            }
            return View(dataManager.Videoadapters.GetVideoadapters());
        }

        [HttpPost]
        public IActionResult ChooseSoundCard(string videoadapterId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (videoadapterId != null)
            {
                Response.Cookies.Append("VideoadapterId", videoadapterId);
            }

            if (Request.Cookies.ContainsKey("MotherboardId"))
            {
                string motherboardId = Request.Cookies["MotherboardId"];
                return View(dataManager.SoundCards.GetSoundCardsBySocket(new Guid(motherboardId)));
            }
            return View(dataManager.SoundCards.GetSoundCards());
        }

        [HttpPost]
        public IActionResult ChooseStorageDevice(string soundCardId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (soundCardId != null)
            {
                Response.Cookies.Append("SoundCardId", soundCardId);
            }

            if (Request.Cookies.ContainsKey("MotherboardId"))
            {
                string motherboardId = Request.Cookies["MotherboardId"];
                return View(dataManager.StorageDevices.GetStorageDevicesBySocket(new Guid(motherboardId)));
            }
            return View(dataManager.StorageDevices.GetStorageDevices());
        }

        [HttpPost]
        public IActionResult ChoosePowerUnit(string storageDeviceId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (storageDeviceId != null)
            {
                Response.Cookies.Append("StorageDeviceId", storageDeviceId);
            }

            if (Request.Cookies.ContainsKey("MotherboardId"))
            {
                string motherboardId = Request.Cookies["MotherboardId"];
                return View(dataManager.PowerUnits.GetPowerUnitsBySocket(new Guid(motherboardId)));
            }
            return View(dataManager.PowerUnits.GetPowerUnits());
        }

        [HttpPost]
        public IActionResult EndComplictation(string powerUnitId)
        {
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeword("PageServices"); // <----- Менять для моделей?

            if (powerUnitId != null &&
                Request.Cookies.ContainsKey("MotherboardId") &&
                Request.Cookies.ContainsKey("ProcessorId") &&
                Request.Cookies.ContainsKey("VideoadapterId") &&
                Request.Cookies.ContainsKey("SoundCardId") &&
                Request.Cookies.ContainsKey("StorageDeviceId")
                )
            {
                var component = new Component();
                component.Motherboard = Request.Cookies["MotherboardId"];
                component.Processor = Request.Cookies["ProcessorId"];
                component.Videoadapter = Request.Cookies["VideoadapterId"];
                component.SoundCard = Request.Cookies["SoundCardId"];
                component.StorageDevice = Request.Cookies["StorageDeviceId"];
                component.PowerUnit = powerUnitId;
                dataManager.Components.SaveComponent(component);
                Response.Cookies.Delete("MotherboardId");
                Response.Cookies.Delete("ProcessorId");
                Response.Cookies.Delete("VideoadapterId");
                Response.Cookies.Delete("SoundCardId");
                Response.Cookies.Delete("StorageDeviceId");
                RedirectToAction("Show", "Components");
            }

            return RedirectToAction("Index", "Components");
        }

        public IActionResult Edit(Guid id)
        {
            var item = id == default ? new Component() : dataManager.Components.GetComponentById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Component model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Components.SaveComponent(model);
                return RedirectToAction(nameof(ComponentsController.Index), nameof(ComponentsController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Components.DeleteComponent(id);
            return RedirectToAction(nameof(ComponentsController.Index), nameof(ComponentsController).CutController());
        }
    }
}
