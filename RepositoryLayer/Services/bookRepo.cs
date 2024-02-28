using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class bookRepo :IUserBookRepo
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public bookRepo(IConfiguration configuration) 
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }

    }
}
