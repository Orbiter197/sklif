using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace EverydayPatientInfo.ProjectStructure.DataBaseStructure
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Port=3306; Username=root; Password=[-Vse-5*0-lod-]; Database=everyday_patient_info");

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

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    } 
}
