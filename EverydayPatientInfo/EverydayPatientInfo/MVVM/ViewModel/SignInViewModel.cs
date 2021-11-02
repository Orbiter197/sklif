using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;



namespace EverydayPatientInfo.MVVM.ViewModel
{

    class SignInViewModel : ObservableObject
    {
        #region Private fields

        private MainWindowViewModel baseVM;
        #endregion

        #region Public properties

        public MainWindowViewModel BaseVM { get => baseVM; }
        #endregion

        #region Public binding properties

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
        public SignInViewModel(MainWindowViewModel baseVM)  
        {
            this.baseVM = baseVM;

            SignInCommand = new RelayCommand(SignIn);
            RegisterCommand = new RelayCommand(baseVM.SwitchToSignUp);
            ResetPasswordCommand = new RelayCommand(baseVM.SwitchToPasswordReset);
        }

        #endregion

        #region Private methods

        private void SignIn()
        {
            if (Authorization.SignIn(CardID, Password))
                baseVM.SwitchToMainContent();

        }

        #endregion
    }
}
