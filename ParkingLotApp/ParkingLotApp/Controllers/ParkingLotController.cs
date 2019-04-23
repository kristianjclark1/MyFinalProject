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
        private List<ParkingLot> ParkingLots = new List<ParkingLot>
        {
            new ParkingLot { Id = 1, Address = "1500 University", Location = "On street", Floor = "None" },
            new ParkingLot { Id = 2, Address = "600 Guadalupe", Location = "On street", Floor = "None" },
        };

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

        public IActionResult Detail(int id)
        {
           var ParkingLot = ParkingLots.Single(p => p.Id == id);

           return View(ParkingLot);
        }

        public IActionResult Delete(int id)
        {
            var ParkingLot = ParkingLots.Single(p => p.Id == id);

            ParkingLots.Remove(ParkingLot);

            return View(nameof(Index), ParkingLots);
        }

        
            

    }
}