using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Interfaces
{
    public interface IParkingLotRepository
    {
        //Read
        ParkingLot GetById(int id);
        ICollection<ParkingLot> GetAllParkingLots();

        //Create
        ParkingLot Create(ParkingLot newparkingLot);

        //Update
        ParkingLot Update(ParkingLot updatedparkingLot);

        //Delete
        bool Delete(int id);
    }
}
