using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// The view model for Regestration Window and <see cref="RegisterationModel"/>
    /// </summary>
    class RegisterationViewModel : ObservableObject
    {
        #region Private fields

        /// <summary>
        /// The model of Register window
        /// </summary>
        private RegisterationModel model;

        #endregion

        #region Public properties

        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        #endregion

        private void Register()
        {
            if(true)
                MainWindowViewModel.Instance.CurrentView = MainWindowViewModel.Instance.SignInVM;
        }

        private void ToLoginPage()
        {
            MainWindowViewModel.Instance.CurrentView = MainWindowViewModel.Instance.SignInVM;
        }

        #region Constructor

        public RegisterationViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
            LoginCommand = new RelayCommand(ToLoginPage);
        }
        
        #endregion
    }
}
