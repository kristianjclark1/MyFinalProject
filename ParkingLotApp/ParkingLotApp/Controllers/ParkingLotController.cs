using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Domain.Models;
using ParkingLotApp.Service.Services;

namespace ParkingLotApp.WebUI.Controllers
{
    public class ParkingLotController : Controller
    {
        private readonly IParkingLotService _parkinglotService;

        public ParkingLotController(IParkingLotService parkingLotService)
        {
            _parkinglotService = parkingLotService;
        }
        //parkinglot/index
        public IActionResult Index()
        {
            var parkinglots = _parkinglotService.GetAllParkingLots();
            return View(parkinglots);
        }
    

//        //GET parkinglot/add
//        public IActionResult Add()
//        {
//            return View("Form");
//        }

//        [HttpPost]
//        public IActionResult Add(ParkingLot newParkingLot)
//        {
//            if (ModelState.IsValid) // all required fields are completed
//            {
//                //We should be able to add the new parking lot
//                ParkingLots.Add(newParkingLot);
//                return View(nameof(Index), ParkingLots);
//            }

//            return View("Form");
//        }

//        public IActionResult Detail(int id)
//        {
//           var ParkingLot = ParkingLots.Single(p => p.Id == id);

//           return View(ParkingLot);
//        }

//        public IActionResult Delete(int id)
//        {
//            var ParkingLot = ParkingLots.Single(p => p.Id == id);

//            ParkingLots.Remove(ParkingLot);

//            return View(nameof(Index), ParkingLots);
//        }

//        public IActionResult Edit(int id)
//        {
//            var ParkingLot = ParkingLots.Single(p => p.Id == id);

//            return View("Form", ParkingLot);
//        }

//        [HttpPost]
//        public IActionResult Edit(int id, ParkingLot updatedParkingLot )
//        {
//            if (ModelState.IsValid)
//            {

//                var oldParkingLot = ParkingLots.Single(p => p.Id == id);

//                oldParkingLot.Address = updatedParkingLot.Address;
//                oldParkingLot.Location = updatedParkingLot.Location;
//                oldParkingLot.Floor = updatedParkingLot.Floor;
//                oldParkingLot.Spaces = updatedParkingLot.Spaces;
//                oldParkingLot.Size = updatedParkingLot.Size;
//                oldParkingLot.Handicap = updatedParkingLot.Handicap;

//                return View(nameof(Index), ParkingLots);
//            }

//            return View("Form", updatedParkingLot); //By passing updatedParkingLot
//                                                    //We trigger the logic
//                                                    //for Edit within the Form.cshtml        
//        }

        
            

    }
}