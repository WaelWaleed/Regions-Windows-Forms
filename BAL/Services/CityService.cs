using DAL.Models;
using DAL.Models.Cities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public class CityService
    {
        private readonly CityRepository _repository;

        public CityService()
        {
            _repository = new CityRepository();
        }

        public List<CitiesViewModel> GetAll()
        {
            return _repository.GetAll();
        }

        public DbResult Insert(string name, Guid countryId)
        {
            var City = new City
            {
                Id = Guid.NewGuid(),
                Name = name,
                CountryId = countryId
            };

            return _repository.Insert(City);
        }

        public DbResult Update(Guid id, string name, Guid countryId)
        {
            var City = new City
            {
                Id = id,
                Name = name,
                CountryId = countryId
            };

            return _repository.Update(City);
        }

        public DbResult Delete(Guid id)
        {
            return _repository.Delete(id);
        }
    }
}
