using Microsoft.EntityFrameworkCore;
using ParkingLotApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Context
{
    //DbContext -> represent a session to a db and provides APIs
    //to communicate with db
    public class ParkingLotAppDbContext : DbContext
    {
       //Represents a collection (table) of a given entity/model
       //They map to table by default
        public DbSet<ParkingLot> parkingLots { get; set; }

        //Virtual method designed to be overridden
        //You can provide configuration info for the context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string is divided in 3 elements
            //server - database - authentication
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=parkinglotapp;Trusted_Connection=true");
        }
         
    }
}
