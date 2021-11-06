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
        public static Patient CreatePatient()
        {
            return new Patient();
        }
        public static bool Add(Patient p)
        {
            MySqlCommand command;
            command = new("INSERT INTO patients(chamber, last_name, first_name, patronymic, attached_data, doctor_id)" +
                "VALUES(@chamber, @last_name, @first_name, @patronymic, @attached_data, @doctor_id)",DataBaseHandler.Connection);
            command.Parameters.Add("@chamber", MySqlDbType.Int32).Value = p.Chamber;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = p.LastName;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = p.FirstName;
            command.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = p.Patronymic;
            command.Parameters.Add("@attached_data", MySqlDbType.JSON).Value = JsonSerializer.Serialize<PatientJsonData>(p.Data);
            command.Parameters.Add("@doctor_id", MySqlDbType.Int32).Value = ProjectMainClass.UserID;
            DataBaseHandler.Open();
            int res = command.ExecuteNonQuery();
            DataBaseHandler.Close();
            return (res != 0);
        }
        public static bool Update(Patient p)
        {
            throw new NotImplementedException();
        }
        public static bool Remove(Patient p)
        {
            throw new NotImplementedException();
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
                {
                    ID = (reader.IsDBNull(0)) ? null : reader.GetFieldValue<int>(0),
                    Chamber = (reader.IsDBNull(1)) ? null : reader.GetFieldValue<int>(1),
                    LastName = (reader.IsDBNull(2)) ? null : reader.GetFieldValue<string>(2),
                    FirstName = (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3),
                    Patronymic = (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4),
                    SickLeave = (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5),
                    Data = (reader.IsDBNull(6)) ? null : JsonSerializer.Deserialize<PatientJsonData>(reader.GetFieldValue<string>(6)),
                    DoctorID   = (reader.IsDBNull(7)) ? null : reader.GetFieldValue<int>(7)
            });
            }
            reader.Close();
            DataBaseHandler.Close();
            return pl;
                    
        }
        public static void AddValues(Patient patient, 
            double pressureEvening, 
            double pressureMorning, 
            double SugarEvening,
            double SugarMorning,
            double WeightEvening,
            double WeightMorning,
            double Height)
        {
            patient.Data.PressureEvening = new List<double>(patient.Data.PressureEvening) { pressureEvening }.ToArray();
            patient.Data.PressureMorning = new List<double>(patient.Data.PressureMorning) { pressureMorning }.ToArray();
            patient.Data.SugarEvening    = new List<double>(patient.Data.SugarEvening) { SugarEvening }.ToArray();
            patient.Data.SugarMorning    = new List<double>(patient.Data.SugarMorning) { SugarMorning }.ToArray();
            patient.Data.WeightEvening   = new List<double>(patient.Data.WeightEvening) { WeightEvening }.ToArray();
            patient.Data.WeightMorning   = new List<double>(patient.Data.WeightMorning) { WeightMorning }.ToArray();
            patient.Data.Height          = new List<double>(patient.Data.Height) { Height }.ToArray();
        }
        
    }                                                  
}                                                      
                                                       