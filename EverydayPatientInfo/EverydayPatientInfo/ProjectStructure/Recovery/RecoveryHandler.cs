using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.Recovery
{
    public static class RecoveryHandler
    {
        public static void Drop()
        {
            MySqlCommand command;

            DataBaseHandler.Open();
            try
            {
                command = new("DROP TABLE patients;", DataBaseHandler.Connection);
                command.ExecuteNonQuery();
            }
            catch { }
            try
            {
                command = new("DROP TABLE employees;", DataBaseHandler.Connection);
                command.ExecuteNonQuery();
            }
            catch { }
            DataBaseHandler.Close();
        }
        public static void Restore(string path)
        {
            string str;
            try
            {
                str = File.ReadAllText(path);
            }
            catch (Exception)
            {
                return;
            }
            
            DataRecovery recovery = JsonSerializer.Deserialize<DataRecovery>(str);

            MySqlCommand command;

            DataBaseHandler.Open();
            try
            {
                command = new("DROP TABLE patients;", DataBaseHandler.Connection);
                command.ExecuteNonQuery();
            }
            catch { }
            try
            {
                command = new("DROP TABLE employees;", DataBaseHandler.Connection);
                command.ExecuteNonQuery();
            }
            catch { }

            command = new("CREATE TABLE employees(" +
                "id INT PRIMARY KEY AUTO_INCREMENT," +
                "card_id VARCHAR(10) UNIQUE not null," +
                "pass VARCHAR(20) not null," +
                "last_name VARCHAR(20) not null," +
                "first_name VARCHAR(20) not null," +
                "patronymic VARCHAR(20)," +
                "role INT not null DEFAULT(0)" +
                "); ", DataBaseHandler.Connection);
            command.ExecuteNonQuery();
            foreach (EmployeeRecovery item in recovery.EmployeeRecoveries)
            {
                command = new("INSERT INTO employees(id, card_id,pass,last_name,first_name, patronymic) VALUES(" +
                    "@id, @card_id, @pass, @last_name, @first_name, @patronymic);", DataBaseHandler.Connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = item.ID;
                command.Parameters.Add("@card_id", MySqlDbType.VarChar).Value = item.CardID;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = item.Pass;
                command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = item.LastName;
                command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = item.FirstName;
                command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = item.Patronymic;
                command.ExecuteNonQuery();
            }

            command = new("CREATE TABLE patients(" +
                    "id INT AUTO_INCREMENT," +
                    "chamber INT," +
                    "last_name VARCHAR(20) not null," +
                    "first_name VARCHAR(20) not null," +
                    "patronymic VARCHAR(20)," +
                    "date_of_birth VARCHAR(20)," +
                    "sick_leave_number VARCHAR(30) not null," +
                    "attached_data JSON," +
                    "doctor_id INT," +
                    "PRIMARY KEY(id)," +
                    "FOREIGN KEY(doctor_id) REFERENCES employees(id) ON DELETE SET null" +
                    "); ", DataBaseHandler.Connection);
            command.ExecuteNonQuery();

            foreach (PatientRecovery item in recovery.PatientRecoveries)
            {
                command = new("INSERT INTO patients(chamber, last_name, first_name, patronymic, date_of_birth, sick_leave_number, attached_data, doctor_id)" +
                "VALUES(@chamber, @last_name, @first_name, @patronymic, @date_of_birth, @sick_leave_number, @attached_data, @doctor_id);", DataBaseHandler.Connection);
                command.Parameters.Add("@chamber", MySqlDbType.Int32).Value = item.Chamber;
                command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = item.LastName;
                command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = item.FirstName;
                command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = item.Patronymic;
                command.Parameters.Add("@date_of_birth", MySqlDbType.VarChar).Value = item.DateOfBirth;
                command.Parameters.Add("@sick_leave_number", MySqlDbType.VarChar).Value = item.SickLeave;
                command.Parameters.Add("@attached_data", MySqlDbType.JSON).Value = JsonSerializer.Serialize<List<PatientRecoveryData>>(item.PatientDataList);
                command.Parameters.Add("@doctor_id", MySqlDbType.Int32).Value = item.DoctorID;
                command.ExecuteNonQuery();
            }

            DataBaseHandler.Close();

        }

        public static void BackUp(string path)
        {
            List<EmployeeRecovery> employeeRecoveries = new();
            List<PatientRecovery> patientRecoveries = new();

            MySqlCommand command;
            MySqlDataReader reader;

            DataBaseHandler.Open();
            command = new("SELECT * FROM employees;", DataBaseHandler.Connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                employeeRecoveries.Add(new(
                    reader.GetFieldValue<int>(0), //id
                    (reader.IsDBNull(1)) ? null : reader.GetFieldValue<string>(1), //cardID
                    (reader.IsDBNull(2)) ? null : reader.GetFieldValue<string>(2), //pass
                    (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3), //lastName
                    (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4), //firstName
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5), //patronymic
                    reader.GetFieldValue<int>(6) //role
                    ));
            }
            reader.Close();
            command = new("SELECT * FROM patients;", DataBaseHandler.Connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                patientRecoveries.Add(new(
                    reader.GetFieldValue<int>(0), //id
                    reader.GetFieldValue<int>(1), //chamber
                    (reader.IsDBNull(2)) ? null : reader.GetFieldValue<string>(2), //lastName
                    (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3), //firstName
                    (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4), //patronymic
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5), //dateOfBirth
                    (reader.IsDBNull(6)) ? null : reader.GetFieldValue<string>(6), //sickLeave
                    (reader.IsDBNull(6)) ? null : JsonSerializer.Deserialize<List<PatientRecoveryData>>(reader.GetFieldValue<string>(7)), //patientDataList
                    reader.GetFieldValue<int>(8) //role
                    ));
            }
            reader.Close();
            DataBaseHandler.Close();

            DataRecovery recovery = new(employeeRecoveries, patientRecoveries);
            string str = JsonSerializer.Serialize<DataRecovery>(recovery);
            File.WriteAllText(path, str);
        }
    }
}
