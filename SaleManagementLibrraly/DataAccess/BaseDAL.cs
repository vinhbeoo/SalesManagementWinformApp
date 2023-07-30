﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SaleManagementLibrraly.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;

        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);
        }
        //
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionStrings:MyStockDB"];
            return connectionString;
        }
        //
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
