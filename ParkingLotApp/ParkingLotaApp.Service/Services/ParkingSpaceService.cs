using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Service.Services
{
    public interface IParkingSpaceService
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

        List<ParkingSpace>GetParkingSpace(ParkingLot lot);
    }

    public class ParkingSpaceService : IParkingSpaceService
    {
        private readonly IParkingSpaceRepository _parkingSpaceRepository;

        public ParkingSpaceService(IParkingSpaceRepository parkingSpaceRepository)
        {
            _parkingSpaceRepository = parkingSpaceRepository;
        }
            
        ParkingSpace IParkingSpaceService.GetById(int spaceId)
        {
            return _parkingSpaceRepository.GetById(spaceId);
        }

        public ICollection<ParkingSpace> GetAllParkingSpaces()
        {
            return _parkingSpaceRepository.GetAllParkingSpaces();
        }

        public ParkingSpace Create(ParkingSpace newparkingSpace)
        {
            return _parkingSpaceRepository.Create(newparkingSpace);
        }

        public ParkingSpace Update(ParkingSpace updatedparkingSpace)
        {
            return _parkingSpaceRepository.Update(updatedparkingSpace);
        }
        
        public List<ParkingSpace> GetParkingSpace(ParkingLot lot)
        {
            return _parkingSpaceRepository.GetParkingSpace(lot);
        }
        public bool Delete(int spaceId)
        {
            return _parkingSpaceRepository.Delete(spaceId);
        }
    }




}
