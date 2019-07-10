using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ParkingLotApp.Domain.Model
{
    public class ParkingLotType
    {
        public int Id { get; set; } //PK in DB table

        [Required] //Make sure that entry contains a description
        public string Description { get; set; }

        
    }
}
