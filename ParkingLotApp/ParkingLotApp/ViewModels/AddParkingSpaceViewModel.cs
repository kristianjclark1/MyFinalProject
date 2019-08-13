using Microsoft.AspNetCore.Mvc.Rendering;
using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApp.WebUI.ViewModels
{
    public class AddParkingSpaceViewModel
    {
        
        public ParkingLot parkingLot { get; set; }

        public List<ParkingSpace> Spaces { get; set; }

        public IEnumerable<SelectListItem> ParkingSpaces
        {
            get { return new SelectList(Spaces, "ParkingSpaceId"); }
        }

        public ParkingSpace parkingSpace { get; set; }

        
    }
}
