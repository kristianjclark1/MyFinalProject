using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLotApp.Models
{
    public class RegisterViewModel
    {
        [EmailAddress, Required]
        public string Email { get; set; }

        [DataType(DataType.Password), Required]
        public string Password { get; set; }

        [DataType(DataType.Password), Required]
        [Compare(nameof(Password), ErrorMessage ="Make sure your password matches")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Role { get; set; }

        public List<IdentityRole> Roles { get; set; }
    }
}
