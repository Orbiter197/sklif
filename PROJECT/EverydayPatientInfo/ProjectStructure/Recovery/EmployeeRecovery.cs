using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.Recovery
{
    class EmployeeRecovery
    {
        public int ID { get; set; }
        public string CardID { get; set; }
        public string Pass { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int Role { get; set; }

        public EmployeeRecovery(int iD, string cardID, string pass, string lastName, string firstName, string patronymic, int role)
        {
            ID = iD;
            CardID = cardID;
            Pass = pass;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Role = role;
        }
    }
}
