using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PatientDetailViewModel : ObservableObject
    {
        #region Private fields

        private DoctorViewModel baseVM;

        private Patient patient;
        #endregion

        #region Public properties

        public ObservableObject BaseVMD { get => baseVM; }


        #endregion

        #region Binding properties

        /// <summary>
        /// Chamber number represented as <code string/>.
        /// </summary>
        public string Chamber { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Patronymic
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Patronymic
        /// </summary>
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Sick Leave Number
        /// </summary>
        public string SickLeave { get; set; }

        public ICommand GoBackCommand { get; set; }
        public ICommand Delete { get; set; }
        public ICommand Save { get; set; }

        #endregion

        #region Constructor

        public PatientDetailViewModel(DoctorViewModel baseVM)
        {
            this.baseVM = baseVM;
            this.patient = null;

            GoBackCommand = new RelayCommand(baseVM.SwitchToTable);
            Delete = new RelayCommand(ConfirmRemoving);
            Save = new RelayCommand(ConfirmAdding);

            Chamber = null;
            LastName = null;
            FirstName = null;
            Patronymic = null;
            DateOfBirth = null;
            SickLeave = null;
        }

        public PatientDetailViewModel(DoctorViewModel baseVM, Patient patient)
        {
            this.baseVM = baseVM;
            this.patient = patient;

            GoBackCommand = new RelayCommand(baseVM.SwitchToTable);
            Delete = new RelayCommand(ConfirmRemoving);
            Save = new RelayCommand(ConfirmModifying);

            Chamber = (patient.Chamber == null) ? null : patient.Chamber.ToString();
            LastName = patient.LastName;
            FirstName = patient.FirstName;
            Patronymic = patient.Patronymic;
            DateOfBirth = patient.DateOfBirth;
            SickLeave = patient.SickLeave;
        }

        private void ConfirmAdding()
        {
            if (Chamber == null || LastName == null || FirstName == null || Patronymic == null || DateOfBirth == null|| SickLeave == null)
                return;

            PatientLogicHandler.Add(int.Parse(Chamber), LastName, FirstName, Patronymic, DateOfBirth, SickLeave);
            baseVM.SwitchToTable();
        }
        private void ConfirmModifying()
        {
            if (Chamber == null || LastName == null || FirstName == null || Patronymic == null || SickLeave == null)
                return;

            PatientLogicHandler.Modify(patient, int.Parse(Chamber), LastName, FirstName, Patronymic, DateOfBirth, SickLeave);
            baseVM.SwitchToTable();

        }
        private void ConfirmRemoving()
        {
            PatientLogicHandler.Remove(patient);
            baseVM.SwitchToTable();
        }




        #endregion
    }
}
