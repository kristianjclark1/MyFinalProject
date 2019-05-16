using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Service.Services
{
    public interface IParkingLotTypeService
    {
        ParkingLotType GetById(int id);
        ICollection<ParkingLotType> GetAll();
    }

    public class ParkingLotTypeService : IParkingLotTypeService
    {
        private readonly IParkingLotTypeRepository _parkingLotTypeRepository;

        public ParkingLotTypeService(IParkingLotTypeRepository parkingLotTypeRepository)
        {
            _parkingLotTypeRepository = parkingLotTypeRepository;
        }
        public ICollection<ParkingLotType> GetAll()
        {
            return _parkingLotTypeRepository.GetAll();
        }

        public ParkingLotType GetById(int id)
        {
            return _parkingLotTypeRepository.GetById(id);
        }
    }
}
