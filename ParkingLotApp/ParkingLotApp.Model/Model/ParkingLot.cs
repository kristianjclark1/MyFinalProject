using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ParkingLot
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Don't forget to add the location of the lot")]
        public string Address { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Floor { get; set; }

        public int Spaces { get; set; }
        [Display(Name ="Lot Size")]
        public int Size { get; set; }
        public bool Handicap { get; set; }
        public string Geomap { get; set; }

        //Fully defined Relationship
        [Display(Name = "Parking Lot Type")]
        public int ParkingLotTypeId { get; set; }
        public ParkingLotType ParkingLotType { get; set; }

        //Fully defined Relationship for App User
        public string AppUserId { get; set; }
        public AppUser Driver { get; set; }

        public ICollection<ReserveParkingSpace> Reservations { get; set; }



    }
}
