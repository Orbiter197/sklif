using System;
using System.Collections.Generic;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class Patient
    {
        /// <summary>
        /// Patient ID. User should not see it
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

        public string DateOfBirth { get; set; }

        /// <summary>
        /// Sick Leave Number
        /// </summary>
        public string SickLeave { get; set; }

        /// <summary>
        /// List of data for each day
        /// </summary>
        public List<PatientData> PatientDataList { get; set; }


        /// <summary>
        /// Doctor ID
        /// </summary>
        public int? DoctorID { get; set; }

        public Patient(int? iD, int? chamber, string lastName, string firstName, string patronymic, string dateOfBirth, string sickLeave, List<PatientData> patientDataList, int? doctorID)
        {
            ID = iD;
            Chamber = chamber;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            SickLeave = sickLeave;
            PatientDataList = patientDataList;
            DoctorID = doctorID;
        }

        public Patient(int? chamber, string lastName, string firstName, string patronymic, string dateOfBirth, string sickLeave)
        {
            ID = null;
            Chamber = chamber;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            SickLeave = sickLeave;
            PatientDataList = new List<PatientData>();
            DoctorID = ProjectMainClass.UserID;
        }
    }
}
