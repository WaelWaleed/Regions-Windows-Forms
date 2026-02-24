using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Database
{
    public class DbHelper
    {
        private readonly string _connectionString;

        public DbHelper()
        {
            _connectionString = @"Server=.;Database=Regions;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public SqlConnection GetConnection() 
        {
            return new SqlConnection(_connectionString);
        }
    }
}
