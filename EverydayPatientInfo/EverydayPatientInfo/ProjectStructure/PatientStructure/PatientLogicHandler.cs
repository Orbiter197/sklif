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
                                                       