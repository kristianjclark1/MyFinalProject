using ParkingLotApp.Data.Context;
using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Implementation.SqlServer
{
    public class SqlServerParkingLotRepository : IParkingLotRepository
    {
        public ParkingLot GetById(int id)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                //SQL -> Database look for table parkingLots
               var  parkinglot = context.parkingLots.Single(p => p.Id == id);
               return parkinglot;
            }
        }

        public ICollection<ParkingLot> GetAllParkingLots()
        {
            using (var context = new ParkingLotAppDbContext())
            {
                return context.parkingLots.ToList(); //Now it is a collection
            }
        }
        public ParkingLot Create(ParkingLot newparkingLot)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                context.parkingLots.Add(newparkingLot);
                context.SaveChanges();

                return newparkingLot; //newparkingLot.Id will be populated with new DB volumn.
            }
        }

        public ParkingLot Update(ParkingLot updatedparkingLot)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                //find the old entity
                var oldParkingLot = GetById(updatedparkingLot.Id);

                //update each entity properties / get; set;
                context.Entry(oldParkingLot).CurrentValues.SetValues(updatedparkingLot);

                //save changes
                context.SaveChanges();

                return oldParkingLot; //To ensure save happened
            }
        }

        public bool Delete(int id)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                //Find what we are going to delete
                var parkinglotToBeDeleted = GetById(id);

                //Delete
                context.parkingLots.Remove(parkinglotToBeDeleted);

                //Save changes
                context.SaveChanges();

                //check if entity/model exists
                if(GetById(id) == null)
                {
                    return true;
                }

                return false;
            }

        }

       
    }
}
