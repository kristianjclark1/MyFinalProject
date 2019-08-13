using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ParkingSpace
    {
      
       

        public int ParkingSpaceId { get; set; }
        public ParkingLot ParkingLot { get; set; }

        public bool Reserved { get; set; }

        
    }
}
