using DAL.Database;
using DAL.Extensions;
using DAL.Models;
using DAL.Models.Cities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.Repositories
{
    public class CityRepository
    {
        private readonly DbHelper _dbHelper;

        public CityRepository()
        {
            _dbHelper = new DbHelper();
        }

        public List<CitiesViewModel> GetAll()
        {
            List<CitiesViewModel> countries = new List<CitiesViewModel>();

            using var connection = _dbHelper.GetConnection();
            using var command = new SqlCommand("spCity_SelectAll", connection);

            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var City = new CitiesViewModel
                {
                    Id = reader.GetGuid(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    CountryName = reader.GetString(reader.GetOrdinal("CountryName")),
                    CountryId = reader.GetGuid(reader.GetOrdinal("CountryId"))
                };

                countries.Add(City);
            }

            return countries;
        }

        public DbResult Insert(City City)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCity_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = City.Id;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = City.Name;
            command.Parameters.Add("@CountryId", SqlDbType.UniqueIdentifier).Value = City.CountryId;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }

        public DbResult Update(City City)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCity_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = City.Id;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = City.Name;
            command.Parameters.Add("@CountryId", SqlDbType.UniqueIdentifier).Value = City.CountryId;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }

        public DbResult Delete(Guid id)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCity_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }
    }
}
