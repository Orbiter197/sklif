using System;
using System.Collections.Generic;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class Patient
    {
        /// <summary>
        /// Patient ID . User should not see it
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Chamber number
        /// </summary>
        public int? Chamber { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Patronymic
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Sick Leave Number
        /// </summary>
        public string SickLeave { get; set; }

        /// <summary>
        /// The data that stored in Json format
        /// </summary>
        public PatientJsonData Data { get; set; }

        /// <summary>
        /// List of data for each day
        /// </summary>
        public List<PatientData> PatientDataList
        {
            get
            {
                List<PatientData> pdl = new();
                for (int i = 0; i < Data.PressureEvening.Length; i++)
                {
                    pdl.Add(
                        new PatientData(Data.PressureEvening[i], Data.PressureMorning[i],
                                        Data.SugarEvening[i], Data.SugarMorning[i],
                                        Data.WeightEvening[i], Data.WeightMorning[i], Data.Height[i]));
                }
                return pdl;
            }
        }

        /// <summary>
        /// Doctor ID
        /// </summary>
        public int? DoctorID { get; set; }

        public Patient()
        {
            
        }

    }
}
