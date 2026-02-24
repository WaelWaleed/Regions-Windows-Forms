using DAL.Models;
using Microsoft.Data.SqlClient;

namespace DAL.Extensions
{
    public static class DbResultHandler
    {
        public static DbResult HandleDbResult(SqlDataReader dataReader)
        {
            if (dataReader.Read())
            {
                return new DbResult
                {
                    Success = dataReader.GetInt32(dataReader.GetOrdinal("Success")) == 1,
                    Message = dataReader.GetString(dataReader.GetOrdinal("Message")),
                    Id = dataReader.IsDBNull(dataReader.GetOrdinal("Id")) ? (Guid?)null : dataReader.GetGuid(dataReader.GetOrdinal("Id"))
                };
            }

            return new DbResult { Success = false, Message = "Unknown Error" };
        }
    }
}
