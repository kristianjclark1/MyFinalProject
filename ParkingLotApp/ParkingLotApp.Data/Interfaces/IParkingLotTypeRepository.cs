using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Data.Interfaces
{
    public interface IParkingLotTypeRepository
    {
        ParkingLotType GetById(int id);
        ICollection<ParkingLotType> GetAll();
    }
}
