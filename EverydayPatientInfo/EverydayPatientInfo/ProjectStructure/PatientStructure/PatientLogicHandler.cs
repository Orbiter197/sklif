using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using EverydayPatientInfo.ProjectStructure;
using MySql.Data.MySqlClient;
namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class PatientLogicHandler
    {
        public static Patient Add(int? chamber, string lastName, string firstName, string patronymic, string dateOfBirth, string sickLeave)
        {
            Patient p = new(chamber, lastName, firstName, patronymic, dateOfBirth, sickLeave);

            MySqlCommand command;
            MySqlDataReader reader;

            DataBaseHandler.Open();
            command = new("SELECT id FROM patients WHERE sick_leave_number = @sick_leave_number;", DataBaseHandler.Connection);
            command.Parameters.Add("@sick_leave_number", MySqlDbType.VarChar).Value = p.SickLeave;
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                DataBaseHandler.Close();
                return null;
            }

            DataBaseHandler.Close();

            DataBaseHandler.Open();
            command = new("INSERT INTO patients(chamber, last_name, first_name, patronymic, date_of_birth, sick_leave_number, attached_data, doctor_id)" +
                "VALUES(@chamber, @last_name, @first_name, @patronymic, @date_of_birth, @sick_leave_number, @attached_data, @doctor_id);", DataBaseHandler.Connection);
            command.Parameters.Add("@chamber", MySqlDbType.Int32).Value = p.Chamber;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = p.LastName;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = p.FirstName;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = p.Patronymic;
            command.Parameters.Add("@date_of_birth", MySqlDbType.VarChar).Value = p.DateOfBirth;
            command.Parameters.Add("@sick_leave_number", MySqlDbType.VarChar).Value = p.SickLeave;
            command.Parameters.Add("@attached_data", MySqlDbType.JSON).Value = JsonSerializer.Serialize<List<PatientData>>(p.PatientDataList);
            command.Parameters.Add("@doctor_id", MySqlDbType.Int32).Value = p.DoctorID;
            command.ExecuteNonQuery();
            p.ID = (int) command.LastInsertedId;
            DataBaseHandler.Close();

            return p;
 
        }
        public static void Modify(Patient patient, int chamber, string lastName, string firstName, string patronymic, string dateOfBirth, string SickLeave)
        {
            patient.Chamber = chamber;
            patient.LastName = lastName;
            patient.FirstName = firstName;
            patient.Patronymic = patronymic;
            patient.DateOfBirth = dateOfBirth;
            patient.SickLeave = SickLeave;

            MySqlCommand command;

            DataBaseHandler.Open();
            command = new("UPDATE patients SET chamber = @chamber, last_name = @last_name, first_name = @first_name, patronymic = @patronymic, date_of_birth = @date_of_birth, sick_leave_number = @sick_leave_number;", DataBaseHandler.Connection);
            command.Parameters.Add("@chamber", MySqlDbType.Int32).Value = patient.Chamber;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = patient.LastName;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = patient.FirstName;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = patient.Patronymic;
            command.Parameters.Add("@date_of_birth", MySqlDbType.VarChar).Value = patient.DateOfBirth;
            command.Parameters.Add("@sick_leave_number", MySqlDbType.VarChar).Value = patient.SickLeave;
            command.ExecuteNonQuery();
            DataBaseHandler.Close();

        }
        public static void Remove(Patient patient)
        {
            MySqlCommand command;

            DataBaseHandler.Open();
            command = new("DELETE FROM patients WHERE id = @id;", DataBaseHandler.Connection);
            command.ExecuteNonQuery();
            DataBaseHandler.Close();
        }
        public static List<Patient> GetByUserID(int? userID)
        {
            List<Patient> pl = new();
            MySqlCommand command;
            
            command = new("SELECT * FROM patients WHERE doctor_id = @doctor_id", DataBaseHandler.Connection);
            command.Parameters.Add("@doctor_id", MySqlDbType.Int32).Value = userID;
            DataBaseHandler.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                pl.Add(new Patient
                (
                    (reader.IsDBNull(0)) ? null : reader.GetFieldValue<int>(0),
                    (reader.IsDBNull(1)) ? null : reader.GetFieldValue<int>(1),
                    (reader.IsDBNull(2)) ? null : reader.GetFieldValue<string>(2),
                    (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3),
                    (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4),
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5),
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(6),
                    (reader.IsDBNull(6)) ? null : JsonSerializer.Deserialize<List<PatientData>>(reader.GetFieldValue<string>(7)),
                    (reader.IsDBNull(7)) ? null : reader.GetFieldValue<int>(8)
            ));
            }
            reader.Close();
            DataBaseHandler.Close();
            return pl;
                    
        }
        public static List<Patient> GetAll()
        {
            List<Patient> pl = new();
            MySqlCommand command;

            command = new("SELECT * FROM patients Limit 50;", DataBaseHandler.Connection);
            DataBaseHandler.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pl.Add(new Patient
                (
                    (reader.IsDBNull(0)) ? null : reader.GetFieldValue<int>(0),
                    (reader.IsDBNull(1)) ? null : reader.GetFieldValue<int>(1),
                    (reader.IsDBNull(2)) ? null : reader.GetFieldValue<string>(2),
                    (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3),
                    (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4),
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5),
                    (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(6),
                    (reader.IsDBNull(6)) ? null : JsonSerializer.Deserialize<List<PatientData>>(reader.GetFieldValue<string>(7)),
                    (reader.IsDBNull(7)) ? null : reader.GetFieldValue<int>(8)
            ));
            }
            reader.Close();
            DataBaseHandler.Close();
            return pl;

        }
        public static void AddValues(Patient patient, 
            double pressureEvening, 
            double pressureMorning, 
            double sugarEvening,
            double sugarMorning,
            double weightEvening,
            double weightMorning,
            double height,
            string notesEvening,
            string notesMorning
            )
        {
            patient.PatientDataList.Add(new PatientData(
                pressureEvening,
                pressureMorning,
                sugarEvening,
                sugarMorning,
                weightEvening,
                weightMorning,
                height,
                notesEvening,
                notesMorning
                ));

            MySqlCommand command;

            DataBaseHandler.Open();

            command = new("UPDATE patients SET attached_data = @attached_data WHERE id = @id;", DataBaseHandler.Connection);
            command.Parameters.Add("@attached_data", MySqlDbType.JSON).Value = JsonSerializer.Serialize<List<PatientData>>(patient.PatientDataList);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = patient.ID;
            command.ExecuteNonQuery();

            DataBaseHandler.Close();

        }
        
    }                                                  
}                                                      
                                                       