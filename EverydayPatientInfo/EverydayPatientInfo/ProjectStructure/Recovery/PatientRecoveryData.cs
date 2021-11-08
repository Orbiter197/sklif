using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayPatientInfo.ProjectStructure.Recovery
{
    class PatientRecoveryData
    {
        public DateTime Date { get; set; }
        public double PressureEvening { get; set; }
        public double PressureMorning { get; set; }
        public double SugarEvening { get; set; }
        public double SugarMorning { get; set; }
        public double WeightEvening { get; set; }
        public double WeightMorning { get; set; }
        public double Height { get; set; } 
        
        public string NotesEvening { get; set; }
        public string NotesMorning { get; set; }

        public PatientRecoveryData(double pressureEvening, double pressureMorning, double sugarEvening, double sugarMorning, double weightEvening, double weightMorning, double height, string notesEvening, string notesMorning)
        {
            PressureEvening = pressureEvening;
            PressureMorning = pressureMorning;
            SugarEvening    = sugarEvening;
            SugarMorning    = sugarMorning;
            WeightEvening   = weightEvening;
            WeightMorning   = weightMorning;
            Height          = height;
            NotesEvening = notesEvening;
            NotesMorning = notesMorning;
            Date = DateTime.Today;
        }
    }
}
