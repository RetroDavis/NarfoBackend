﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionToDatabase
{
    public class Connection
    {

        public string DBConnection()
        {
            string connectionString;
            SqlConnection connect;

            connectionString = @"Data Source=dev.retrotest.co.za;Initial Catalog=narfo;User ID=group2;Password=jtn8TVNQMW_28esy";
            connect = new SqlConnection(connectionString);
            connect.Open();
            bool status = false;

            while (!status)
            {
                return "Open";
            }
            connect.Close();
            return "Closed";
        }
    }
}
