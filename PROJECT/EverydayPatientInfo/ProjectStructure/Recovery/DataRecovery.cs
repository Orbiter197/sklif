using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.Recovery
{
    class DataRecovery
    {
        public List<EmployeeRecovery> EmployeeRecoveries { get; set; }
        public List<PatientRecovery> PatientRecoveries { get; set; }

        public DataRecovery(List<EmployeeRecovery> employeeRecoveries, List<PatientRecovery> patientRecoveries)
        {
            EmployeeRecoveries = employeeRecoveries;
            PatientRecoveries = patientRecoveries;
        }
    }
}
