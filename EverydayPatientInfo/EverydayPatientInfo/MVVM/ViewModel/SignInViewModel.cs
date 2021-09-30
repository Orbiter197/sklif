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
        private MainWindowViewModel parentVM;

        /// <summary>
        /// The model that handles all logic
        /// </summary>
        private readonly SignInModel signInModel;

        /// <summary>
        /// Login 
        /// </summary>
        private string login;

        /// <summary>
        /// Password 
        /// </summary>
        private string password;

        #endregion

        #region Public properties

        /// <summary>
        /// Login 
        /// </summary>
        public string Login
        {
            get => login;
            set => login = value;
        }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password
        {
            get => password;
            set => password = value;
        }

        public ICommand SignInCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand ResetPasswordCommand { get; set; }

        public MainWindowViewModel ParentVM
        {
            get => parentVM;
            set => parentVM = (parentVM != null) ? value : parentVM; 
        }

        #endregion

        #region Private methods

        private void SignIn()
        {
            if (signInModel.SignIn(Login, Password))
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
