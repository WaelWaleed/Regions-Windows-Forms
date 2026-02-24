using DAL.Database;
using DAL.Extensions;
using DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.Repositories
{
    public class CountryRepository
    {
        private readonly DbHelper _dbHelper;
        
        public CountryRepository()
        {
            _dbHelper = new DbHelper();   
        }

        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();

            using var connection = _dbHelper.GetConnection();
            using var command = new SqlCommand("spCountry_SelectAll", connection);

            command.CommandType = CommandType.StoredProcedure;
            connection.Open();

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var country = new Country
                {
                    Id = reader.GetGuid(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name"))
                };

                countries.Add(country);
            }

            return countries;
        }

        public DbResult Insert(Country country)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCountry_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = country.Id;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = country.Name;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }

        public DbResult Update(Country country)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCountry_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = country.Id;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = country.Name;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }

        public DbResult Delete(Guid id)
        {
            using var connection = _dbHelper.GetConnection();

            using var command = new SqlCommand("spCountry_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = id;

            connection.Open();

            using var reader = command.ExecuteReader();

            return DbResultHandler.HandleDbResult(reader);
        }
    }
}
