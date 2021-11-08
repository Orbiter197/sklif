using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class OperatorViewModel : ObservableObject
    {
        #region Private fields

        private MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        #region Binding properties

        public List<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; } = null;

        public string SelectedPatientString { get => ReturnName(); set { } }

        public string PressurreEvening { get; set; }
        public string PressurreMorning { get; set; }
        public string SugarEvening { get; set; }
        public string SugarMorning { get; set; }
        public string WeightEvening { get; set; }
        public string WeightMorning { get; set; }
        public string Height { get; set; }

        public string NotesEvening { get; set; }
        public string NotesMorning { get; set; }

        public ICommand AddDataCommand { get; set; }



        #endregion

        public OperatorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
            PatientList = PatientLogicHandler.GetAll();
            AddDataCommand = new RelayCommand(AddData);
        }
        public string ReturnName()
        {
            if (SelectedPatient == null)
                return "Nobody is selected";

            return SelectedPatient.LastName + " " + SelectedPatient.FirstName + " " + SelectedPatient.Patronymic;
        }

        public void AddData()
        {
            if (SelectedPatient == null) return;
            if (PressurreEvening == null || PressurreMorning == null || SugarEvening == null || SugarMorning == null || WeightEvening == null || WeightMorning == null || Height == null)
                return;
            PatientLogicHandler.AddValues(SelectedPatient, int.Parse(PressurreEvening),
                int.Parse(PressurreMorning), int.Parse(SugarEvening),
                int.Parse(SugarMorning), int.Parse(WeightEvening),
                int.Parse(WeightMorning), int.Parse(Height),
                NotesEvening, NotesMorning);
        }
    }


    
}
