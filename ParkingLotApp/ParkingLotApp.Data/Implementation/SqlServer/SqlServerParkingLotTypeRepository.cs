using ParkingLotApp.Data.Context;
using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotApp.Data.Implementation.SqlServer
{
    public class SqlServerParkingLotTypeRepository : IParkingLotTypeRepository
    {
        public ICollection<ParkingLotType> GetAll()
        {
            using (var context = new ParkingLotAppDbContext())
            {
               return context.ParkingLotTypes.ToList();
            }
        }

        public ParkingLotType GetById(int id)
        {
            using (var context = new ParkingLotAppDbContext())
            {
                return context.ParkingLotTypes.SingleOrDefault(pl => pl.Id == id);

            }

        }
    }
}
