using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.PatientStructure
{
    class PatientExportParams
    {
        public string ColumnName { get; set; }
        public bool IsShown { get; set; }

        public PatientExportParams(string columnName, bool isShown)
        {
            ColumnName = columnName;
            IsShown = isShown;
        }

        public static bool[] MainList { get; private set; } = SetList();

        static bool[] SetList()
        {
            bool[] list = new bool[16];
            for (int i = 0; i < list.Length; i++)
                list[i] = true;
            return list;
            
        }

        public static List<PatientExportParams> GetList()
        {
            List<PatientExportParams> paramsList = new();
            paramsList.Add(new PatientExportParams("Chamber",           MainList[0]));
            paramsList.Add(new PatientExportParams("LastName",          MainList[1]));
            paramsList.Add(new PatientExportParams("FirstName",         MainList[2]));
            paramsList.Add(new PatientExportParams("Patronymic",        MainList[3]));
            paramsList.Add(new PatientExportParams("DateOfBirth",       MainList[4]));
            paramsList.Add(new PatientExportParams("SickLeave",         MainList[5]));
            paramsList.Add(new PatientExportParams("Date",              MainList[6]));
            paramsList.Add(new PatientExportParams("PressureEvening",   MainList[7]));
            paramsList.Add(new PatientExportParams("PressureMorning",   MainList[8]));
            paramsList.Add(new PatientExportParams("SugarEvening",      MainList[9]));
            paramsList.Add(new PatientExportParams("SugarMorning",      MainList[10]));
            paramsList.Add(new PatientExportParams("WeightEvening",     MainList[11]));
            paramsList.Add(new PatientExportParams("WeightMorning",     MainList[12]));
            paramsList.Add(new PatientExportParams("Height",            MainList[13]));
            paramsList.Add(new PatientExportParams("NotesEvening",      MainList[14]));
            paramsList.Add(new PatientExportParams("NotesMorning",      MainList[15]));
            return paramsList;
        }

        public static void GetDefault(List<PatientExportParams> paramsList)
        {
            for (int i = 0; i < paramsList.Count; i++)
                paramsList[i].IsShown = MainList[i];
            
        }
        public static void SetDefault(List<PatientExportParams> paramsList)
        {
            for (int i = 0; i < paramsList.Count; i++)
                MainList[i] = paramsList[i].IsShown;
        }
    }
}
