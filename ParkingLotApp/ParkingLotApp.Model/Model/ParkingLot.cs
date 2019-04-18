using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingLotApp.Models
{
    public class ParkingLot
    {
        public string Address { get; set; }
        public string Location { get; set; }
        public string Floor { get; set; }
        public int Spaces { get; set; }
        public int Size { get; set; }
        public bool Handicap { get; set; }
    }
}
