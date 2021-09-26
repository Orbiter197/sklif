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
        #region Private properties

        /// <summary>
        /// The model that handles all logic
        /// </summary>
        private readonly SignInModel signInModel;

        #endregion

        #region Public properties

        /// <summary>
        /// Login 
        /// </summary>
        public string Username
        {
            get => signInModel.Login;
            set => signInModel.Login = value;
        }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password
        {
            get => signInModel.Password;
            set => signInModel.Password = value;
        }

        public ICommand SignInCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ResetPasswordCommand { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SignInViewModel()
        {
            signInModel = new SignInModel(this);


            SignInCommand = new RelayCommand(signInModel.SignIn);
            RegisterCommand = new RelayCommand(signInModel.Register);
            ResetPasswordCommand = new RelayCommand(signInModel.ResetPassword);
        }

        #endregion

    }
}
