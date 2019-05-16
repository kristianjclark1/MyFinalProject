using Microsoft.EntityFrameworkCore;
using ParkingLotApp.Domain.Model;
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
        public DbSet<ParkingLotType> ParkingLotTypes { get; set; }

        //Virtual method designed to be overridden
        //You can provide configuration info for the context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string is divided in 3 elements
            //server - database - authentication
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=parkinglotapp;Trusted_Connection=true");
        }

        //We can manipulate the models
        //Add data to tables
        //change the default relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkingLotType>().HasData(
                new ParkingLotType {Id = 1, Description = "Parking Garage"},
                new ParkingLotType {Id = 2, Description = "On Street"},
                new ParkingLotType {Id = 3, Description = "Business"}
                );
        }
         
    }
}
