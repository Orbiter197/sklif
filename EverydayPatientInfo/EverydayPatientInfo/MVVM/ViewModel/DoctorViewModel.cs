using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;


namespace EverydayPatientInfo.MVVM.ViewModel
{
    class DoctorViewModel : ObservableObject
    {
        #region Private fields

        private MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        #region Binding properties

        public object CurrentView { get; set; }

        #endregion

        public DoctorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
            SwitchToTable();
        }


        #region Public methods

        public void SwitchToTable() => CurrentView = new PatientTableViewModel(this);

        public void AddPatient() => CurrentView = new PatientDetailViewModel(this);
        public void ModifyPatient(Patient p)
        {
            if (p != null) 
                CurrentView = new PatientDetailViewModel(this, p);
        }

        #endregion
    }
}
