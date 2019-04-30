using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Context
{
    class ParkingLotAppDbContext : DbContext
    {
        //Per Model that we want to turn into a table
        //we add it as a DbSet

        DbSet<ParkingLot> ParkingLots { get; set; }

    }
}
