using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class Patient
    {
        public int? ID { get; set; }
        public int? Chamber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public PatientJsonData Data { get; set; }
        public int? Doctor_ID { get; set; }

        public Patient()
        {
            
        }

    }
}
