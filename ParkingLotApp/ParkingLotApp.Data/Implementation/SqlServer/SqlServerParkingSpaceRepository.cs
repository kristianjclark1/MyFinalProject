using ParkingLotApp.Data.Context;
using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotApp.Data.Implementation.SqlServer
{
    public class SqlServerParkingSpaceRepository : IParkingSpaceRepository
    {
        public ParkingSpace GetById(int spaceId)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                var parkingspace = context.ParkingSpaces.SingleOrDefault(p => p.ParkingSpaceId == spaceId);
                return parkingspace;
            }
        }

        public ICollection<ParkingSpace> GetAllParkingSpaces()
        {
            using (var context = new ParkingLotAppDbContext())
            {
                return context.ParkingSpaces.ToList();
            }
        }

        public ParkingSpace Create(ParkingSpace newparkingSpace)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                context.ParkingSpaces.Add(newparkingSpace);
                context.SaveChanges();
                return newparkingSpace;
            }

        }

        public ParkingSpace Update(ParkingSpace updatedparkingSpace)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                //find old entity
                var oldParkingSpace = GetById(updatedparkingSpace.ParkingSpaceId);

                //update each entity properties / get; set;
                context.Entry(oldParkingSpace).CurrentValues.SetValues(updatedparkingSpace);

                //save changes
                context.ParkingSpaces.Update(oldParkingSpace);
                context.SaveChanges();

                return oldParkingSpace; //To ensure save happened

            }

        }

        public bool Delete(int spaceId)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                //Find what we are going to delete
                var parkingSpaceToBeDeleted = GetById(spaceId);

                //Delete
                context.ParkingSpaces.Remove(parkingSpaceToBeDeleted);

                //Save changes
                context.SaveChanges();

                //check if entity/model exists
                if (GetById(spaceId) == null)
                {
                    return true;
                }

                return false;

            }


        }
    }
}