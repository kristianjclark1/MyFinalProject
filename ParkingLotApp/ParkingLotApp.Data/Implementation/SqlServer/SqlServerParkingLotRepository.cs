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

        public ParkingLot Create(ParkingLot newparkingLot)
        {
            throw new NotImplementedException();
        }

        public ParkingLot Update(ParkingLot updatedparkingLot)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
