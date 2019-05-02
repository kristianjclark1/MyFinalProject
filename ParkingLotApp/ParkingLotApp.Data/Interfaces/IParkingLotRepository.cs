using ParkingLotApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Interfaces
{
    interface IParkingLotRepository
    {
        //Read
        ParkingLot GetById(int id);
        //ICollection<ParkingLot> GetByOwnerId(int ownerId);

        //Create
        ParkingLot Create(ParkingLot newparkingLot);

        //Update
        ParkingLot Update(ParkingLot updatedparkingLot);

        //Delete
        bool Delete(int id);
    }
}
