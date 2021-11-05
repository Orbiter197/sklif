using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class Patient
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public PatientJsonData Data { get; set; }

        public Patient()
        {

        }

    }
}
