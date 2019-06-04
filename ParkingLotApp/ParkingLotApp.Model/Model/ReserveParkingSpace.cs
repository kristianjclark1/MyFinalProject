using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ReserveParkingSpace
    {
        public string AppUserId { get; set; }
        public AppUser Driver { get; set; }

        public int ParkingSpaceId { get; set; }
        public ParkingLot ParkingLot { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Double Fare { get; set; }


    }
}
