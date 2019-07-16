using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Domain.Model;

namespace ParkingLotApp.WebUI.Controllers
{
    public class ParkingSpaceController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ParkingSpace newParkingSpace)
        {
            return View();
        }
    }
}