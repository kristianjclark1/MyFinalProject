using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApp.WebUI.ViewModels
{
    public class AddParkingSpaceViewModel
    {
        public int ParkingSpaceId { get; set; }

        public string _parkingLot { get; set; }

        public bool Reserved { get; set; }
    }
}
