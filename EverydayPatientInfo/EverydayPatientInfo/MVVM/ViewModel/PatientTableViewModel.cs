using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PatientTableViewModel : ObservableObject
    {
        #region Private fields

        private DoctorViewModel baseVM;

        #endregion

        #region Public properties

        public ObservableObject BaseVM { get => baseVM; }

        #endregion

        #region Binding properties

        public List<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; } = null;

        public ICommand AddPatientCommand { get; set; }
        public ICommand ModifyPatientCommand { get; set; }

        #endregion

        #region Constructor

        public PatientTableViewModel(DoctorViewModel baseVM)
        {
            this.baseVM = baseVM;
            PatientList = PatientLogicHandler.GetByUserID(ProjectMainClass.UserID);
            AddPatientCommand = new RelayCommand(() => baseVM.AddPatient());
            ModifyPatientCommand = new RelayCommand(() => baseVM.ModifyPatient(SelectedPatient));
        }

        #endregion

        #region Private methods



        #endregion








    }
}
