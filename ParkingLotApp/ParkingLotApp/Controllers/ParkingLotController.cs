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


        //GET parkinglot/add
        public IActionResult Add()
        {
            return View("Form");
        }

        [HttpPost]
        public IActionResult Add(ParkingLot newParkingLot)
        {
            if (ModelState.IsValid) // all required fields are completed
            {
                //We should be able to add the new parking lot
                _parkinglotService.Create(newParkingLot);
                return RedirectToAction(nameof(Index)); // ->Index()
            }

            return View("Form");
        }

        public IActionResult Detail(int id)
        {
            var ParkingLot = _parkinglotService.GetById(id);

            return View(ParkingLot);
        }

        public IActionResult Delete(int id)
        {
            var succeeded = _parkinglotService.Delete(id);

            if (!succeeded) //when delete fails
                ViewBag.Error = "Sorry, the parking lot could not be deleted, please try again later";


            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var ParkingLot = _parkinglotService.GetById(id);

            return View("Form", ParkingLot); //Edit.cshtml, renamed to Form.cshtml
        }

        [HttpPost]
        public IActionResult Edit(int id, ParkingLot updatedParkingLot)
        {
            if (ModelState.IsValid)
            {
                _parkinglotService.Update(updatedParkingLot);

                return RedirectToAction(nameof(Index));

            }

            return View("Form", updatedParkingLot); //By passing updatedParkingLot
                                                    //We trigger the logic
                                                    //for Edit within the Form.cshtml        
        }




    }
}