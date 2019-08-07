﻿using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Interfaces
{
    interface IParkingSpaceRepository
    {
        //Read
        ParkingSpace GetById(int id);
        ICollection<ParkingSpace> GetAllParkingSpaces();

        //Create
        ParkingSpace Create(ParkingSpace newparkingSpace);

        //Update
        ParkingSpace Update(ParkingSpace updatedparkingSpace);

        //Delete
        bool Delete(int id);
    }
}
       
    

