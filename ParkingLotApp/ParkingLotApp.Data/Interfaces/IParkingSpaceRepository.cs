using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Interfaces
{
    public interface IParkingSpaceRepository
    {
        //Read
        ParkingSpace GetById(int spaceId);
        ICollection<ParkingSpace> GetAllParkingSpaces();

        //Create
        ParkingSpace Create(ParkingSpace newparkingSpace);

        //Update
        ParkingSpace Update(ParkingSpace updatedparkingSpace);

        //Delete
        bool Delete(int id);
    }
}
       
    

