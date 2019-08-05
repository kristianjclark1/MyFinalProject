using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApp.WebUI.ViewModels
{
    public class AddParkingSpaceViewModel
    {
        public int ParkingSpaceId { get; set; }

        public ParkingLot parkingLot { get; set; }

        public ParkingSpace parkingSpace { get; set; }

        
    }
}
