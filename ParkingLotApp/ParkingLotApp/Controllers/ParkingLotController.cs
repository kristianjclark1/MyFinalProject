using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Models;

namespace ParkingLotApp.WebUI.Controllers
{
    public class ParkingLotController : Controller
    {
        private List<ParkingLot> ParkingLots = new List<ParkingLot>();

        //parkinglot/index
        public IActionResult Index()
        {
            return View(ParkingLots);
        }

        //GET parkinglot/add
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ParkingLot newParkingLot)
        {
            ParkingLots.Add(newParkingLot);

            return View(nameof(Index), ParkingLots);
        }
    }
}