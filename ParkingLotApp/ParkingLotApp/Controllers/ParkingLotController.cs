using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingLotApp.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ParkingLotApp.WebUI.Controllers
{
    [Authorize(Roles = "Driver")]
    public class ParkingLotController : Controller
    {
        private const string PARKINGLOTTYPE = "ParkingLotTypes";
        private readonly IParkingLotService _parkinglotService;
        private readonly IParkingLotTypeService _parkingLotTypeService;
        private readonly UserManager<AppUser> _userManager;

        public ParkingLotController(IParkingLotService parkingLotService, 
            IParkingLotTypeService parkingLotTypeService,
            UserManager<AppUser> userManager)
        {
            _parkinglotService = parkingLotService;
            _parkingLotTypeService = parkingLotTypeService;
            _userManager = userManager;
        }
        //parkinglot/index
        public IActionResult Index()
        {
            // check if got any error in TempData
            if (TempData["Error"] != null)
            {

                // Pass the error to the ViewData, bc 
                // we are communicating between action and view
                ViewData.Add("Error", TempData["Error"]);
            }

            var parkinglots = _parkinglotService.GetAllParkingLots();
            return View(parkinglots);
        }


        //GET parkinglot/add
        [HttpGet]
        public IActionResult Add()
        {
            GetParkingLotTypes();
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

            GetParkingLotTypes();
            return View("Form");
        }

        [Authorize(Roles ="Driver")]
        public IActionResult Detail(int id)
        {
            var ParkingLot = _parkinglotService.GetById(id);

            return View(ParkingLot);
        }

        public IActionResult Delete(int id)
        {
            var succeeded = _parkinglotService.Delete(id);

            if (!succeeded) //when delete fails
                //using tempdata -bc we are communicating
                //between actions - from Delete to Index
                TempData.Add("Error", "Sorry, the parking lot could not be deleted, please try again later");


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

        private void GetParkingLotTypes()
        {
            var parkingLotTypes = _parkingLotTypeService.GetAll();
            ViewData.Add(PARKINGLOTTYPE, parkingLotTypes);
        }


    }
}