using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.Recovery
{
    class PatientRecovery
    {
        public int? ID { get; set; }
        public int? Chamber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string DateOfBirth { get; set; }
        public string SickLeave { get; set; }
        public List<PatientRecoveryData> PatientDataList { get; set; }
        public int? DoctorID { get; set; }

        public PatientRecovery(int? iD, int? chamber, string lastName, string firstName, string patronymic, string dateOfBirth, string sickLeave, List<PatientRecoveryData> patientDataList, int? doctorID)
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
    }
}
