using System;
using System.Collections.Generic;
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


        public List<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; } = null;
        

        #endregion

        public DoctorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
            Show();
        }

        #region Private methods

        

        #endregion

        #region Public methods

        public void Show()
        {
            PatientList = PatientLogicHandler.GetByUserID(ProjectMainClass.UserID);
        }

        #endregion
    }
}
