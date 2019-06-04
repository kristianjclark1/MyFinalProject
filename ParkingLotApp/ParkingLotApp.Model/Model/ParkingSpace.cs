using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ParkingSpace
    {
        public string AppUserId { get; set; }
        public AppUser Driver { get; set; }

        public int ParkingSpaceId { get; set; }
        public ParkingLot ParkingLot { get; set; }
    }
}
