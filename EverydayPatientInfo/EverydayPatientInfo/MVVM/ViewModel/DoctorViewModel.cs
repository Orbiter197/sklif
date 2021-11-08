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

        public Visibility GridSelection { get; set; }

        public Visibility WindowSelection { get; set; }


        public List<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; } = null;



        /// <summary>
        /// Content provoded to "Switch View" Button
        /// </summary>
        public string SwitchViewContent { get; set; }

        /// <summary>
        /// Command provoded to "Switch View" Button
        /// </summary>
        public ICommand SwitchViewCommand { get; set; }

        /// <summary>
        /// Content provoded to "Modify Patient" Button
        /// </summary>
        public string ModifyPatientContent { get; set; }

        /// <summary>
        /// Content provoded to "Modify Patient" Button
        /// </summary>
        public ICommand ModifyPatientCommand { get; set; }


        #endregion

        public DoctorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
            ShowGrid();
        }

        #region Private methods

        public void ShowGrid()
        {
            GridSelection = Visibility.Visible;
            WindowSelection = Visibility.Hidden;

            SwitchViewContent = "Add New Patient";
            SwitchViewCommand = new RelayCommand(ShowAddNew);
            ModifyPatientContent = "Modify Selected Patient";
            ModifyPatientCommand = new RelayCommand(ShowModify);
            Show();
        }

        public void ShowAddNew()
        {
            CurrentView = new PatientDetailViewModel(this);
        }

        public void ShowModify()
        {
            CurrentView = new PatientDetailViewModel(this, SelectedPatient);
        }

        

        #endregion

        #region Public methods

        public void Show()
        {
            PatientList = PatientLogicHandler.GetByUserID(ProjectMainClass.UserID);
        }

        #endregion
    }
}
