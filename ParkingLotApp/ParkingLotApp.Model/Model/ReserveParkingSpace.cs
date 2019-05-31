using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ReserveParkingSpace
    {
        public int AppUserId { get; set; }

        public int ParkingSpaceId { get; set; }

        public DateTime DateTime { get; set; }

        public Double Fare { get; set; }


    }
}
