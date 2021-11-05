using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class PatientLogicHandler
    {
        public static Patient CreatePatient()
        {
            return new Patient();
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
            patient.Data.SugarEvening = new List<double>(patient.Data.SugarEvening) { SugarEvening }.ToArray();
            patient.Data.SugarMorning = new List<double>(patient.Data.SugarMorning) { SugarMorning }.ToArray();
            patient.Data.WeightEvening = new List<double>(patient.Data.WeightEvening) { WeightEvening }.ToArray();
            patient.Data.WeightMorning = new List<double>(patient.Data.WeightMorning) { WeightMorning }.ToArray();
            patient.Data.Height = new List<double>(patient.Data.Height) { Height }.ToArray();
        }                                              
    }                                                  
}                                                      
                                                       