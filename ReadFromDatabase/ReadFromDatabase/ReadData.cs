﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromDatabase
{
    public class ReadData
    {
        public string DBConnection()
        {
            string connectionString;
            SqlConnection connect;

            connectionString = @"Data Source=dev.retrotest.co.za;Initial Catalog=narfo;User ID=group2;Password=jtn8TVNQMW_28esy";
            connect = new SqlConnection(connectionString);
            connect.Open();

            string command = "SELECT * FROM Members";
            SqlCommand cmd = new SqlCommand(command, connect);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Member memb = new Member();
                memb.ID = Convert.ToInt32(reader["id"]);
                memb.firstName = reader["firstname"].ToString();
                memb.lastName = reader["lastname"].ToString();
                memb.username = reader["username"].ToString();
                memb.password = reader["password"].ToString();

                return memb.firstName;

            }

            connect.Close();
            return "Closed";


        }
    }
}
