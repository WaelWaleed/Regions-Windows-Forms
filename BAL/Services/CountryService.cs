using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Services
{
    public class CountryService
    {
        private readonly CountryRepository _repository;

        public CountryService()
        {
            _repository = new CountryRepository();
        }

        public List<Country> GetAll()
        {
            return _repository.GetAll();
        }

        public DbResult Insert(string name)
        {
            var country = new Country
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            return _repository.Insert(country);
        }

        public DbResult Update(Guid id, string name)
        {
            var country = new Country
            {
                Id = id,
                Name = name
            };

            return _repository.Update(country);
        }

        public DbResult Delete(Guid id)
        {
            return _repository.Delete(id);
        }
    }
}
