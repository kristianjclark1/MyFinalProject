using Microsoft.EntityFrameworkCore;
using ParkingLotApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Context
{
    //This class will translate Models into database tables
    public class ParkingLotAppDbContext : DbContext
    {
       //Per model that we want to turn into table
       //we add it as a dbset

        DbSet<ParkingLot> parkingLots { get; set; }
         
    }
}
