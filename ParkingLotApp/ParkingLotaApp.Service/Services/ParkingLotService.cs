using ParkingLotApp.Data.Interfaces;
using ParkingLotApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotApp.Service.Services
{
    public interface IParkingLotService
    {
        
        //Read
        ParkingLot GetById(int id);
        ICollection<ParkingLot>GetAllParkingLots();

        //Create
        ParkingLot Create(ParkingLot newparkingLot);

        //Update
        ParkingLot Update(ParkingLot updatedparkingLot);

        //Delete
        bool Delete(int id);
    }

    public class ParkingLotService : IParkingLotService
    {
        private readonly IParkingLotRepository _parkinglotRepository;

        //Added dependency to constructor
        public ParkingLotService(IParkingLotRepository parkinglotRepository)
        {
            _parkinglotRepository = parkinglotRepository;
        }
        public ICollection<ParkingLot> GetAllParkingLots()
        {
            return _parkinglotRepository.GetAllParkingLots();
        }

        public ParkingLot Create(ParkingLot newparkingLot)
        {
           return _parkinglotRepository.Create(newparkingLot); //create from repository
        }

        public bool Delete(int id)
        {
            return _parkinglotRepository.Delete(id);
        }

        public ParkingLot GetById(int id)
        {
            return _parkinglotRepository.GetById(id);
        }

        public ParkingLot Update(ParkingLot updatedparkingLot)
        {
            return _parkinglotRepository.Update(updatedparkingLot);
        }
    }

    


}
