using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtXornoSite.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ArtXornoSite.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Snow", dataManager.ServiceItem.GetServiceItemById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItem.GetServiceItems());
        }
    }
}