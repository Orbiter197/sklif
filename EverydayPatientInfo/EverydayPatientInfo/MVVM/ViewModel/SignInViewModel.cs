using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using System.Windows.Input;

using System;
using System.Collections.Generic;
using System.Text;


namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// This view model is used when autification is needed
    /// </summary>
    class SignInViewModel : ObservableObject
    {
        #region Private fields


        /// <summary>
        /// The model that handles all logic
        /// </summary>
        private readonly SignInModel signInModel;

        #endregion

        #region Public properties

        /// <summary>
        /// CardID 
        /// </summary>
        public string CardID { get; set; }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password { get; set; }

        public ICommand SignInCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ResetPasswordCommand { get; set; }

        #endregion

        #region Private methods

        private void SignIn()
        {
            if (signInModel.SignIn(CardID, Password))
            {
                //transition
            }
        }

        private void Register()
        {
            MainWindowViewModel.Instance.CurrentView = MainWindowViewModel.Instance.RegisterVM;
        }

        private void ResetPassword()
        {

        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SignInViewModel()
        {
            signInModel = new SignInModel(this);

            SignInCommand = new RelayCommand(SignIn);
            RegisterCommand = new RelayCommand(Register);
            ResetPasswordCommand = new RelayCommand(ResetPassword);
        }

        #endregion

    }
}
