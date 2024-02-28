using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ModelLayer.Models;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class userAddressRepo :IUserAddressRepo
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public userAddressRepo(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }
        public userAddressModel addUserAddress(userAddressModel userAddress, int userId)
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spAddUserAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@fullAddress", userAddress.fullAddress);
                command.Parameters.AddWithValue("@city", userAddress.city);
                command.Parameters.AddWithValue("@state", userAddress.state);
                command.Parameters.AddWithValue("@type", userAddress.type);
                command.Parameters.AddWithValue("@userId",userId);
                command.ExecuteNonQuery();
            }
            return userAddress;
        }
    }
}
