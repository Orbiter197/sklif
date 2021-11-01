using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;



namespace EverydayPatientInfo.MVVM.ViewModel
{

    class SignInViewModel : ObservableObject
    {
        #region Public properties

        public string CardID { get; set; }
        public string Password { get; set; }

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
            Instances.SignInVMInstance = this;

            SignInCommand = new RelayCommand(SignIn);
            RegisterCommand = new RelayCommand(Register);
            ResetPasswordCommand = new RelayCommand(ResetPassword);
        }

        #endregion

        #region Private methods

        private void SignIn()
        {
            if (Authorization.SignIn(CardID, Password))
                Instances.MainWindowVMInstance.CurrentView = Instances.MainContentVMInstance;

        }

        private void Register()
        {
            Instances.MainWindowVMInstance.CurrentView = Instances.RegisterationVMInstance;
        }

        private void ResetPassword()
        {
            Instances.MainWindowVMInstance.CurrentView = Instances.PasswordResetVMInstance;
        }

        #endregion
    }
}
