using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace EverydayPatientInfo.ProjectStructure.DataBaseStructure
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=everyday_patient_info");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    } 
}
