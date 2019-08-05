using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Domain.Model;
using ParkingLotApp.WebUI.ViewModels;

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
            AddParkingSpaceViewModel addParkingSpaceViewModel = new AddParkingSpaceViewModel();
            return View();
        }

        [HttpPost]
        public IActionResult Add(ParkingSpace newParkingSpace)
        {
            return View();
        }

        public IActionResult Edit(int ParkingSpaceId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int ParkingSpaceId, ParkingSpace updatedParkingSpace)
        {
            return View();
        }
    }
}