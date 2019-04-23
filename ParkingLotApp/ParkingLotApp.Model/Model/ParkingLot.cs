using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingLotApp.Models
{
    public class ParkingLot
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Floor { get; set; }
        public int Spaces { get; set; }
        [Display(Name ="Lot Size")]
        public int Size { get; set; }
        public bool Handicap { get; set; }
    }
}
