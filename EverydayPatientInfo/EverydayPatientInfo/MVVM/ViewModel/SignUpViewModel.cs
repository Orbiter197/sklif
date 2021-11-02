using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class SignUpViewModel : ObservableObject
    {
        #region Private fields

        private MainWindowViewModel baseVM;
        #endregion

        #region Public properties

        public MainWindowViewModel BaseVM { get => baseVM; }
        #endregion

        #region Public binding properties

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public string DateOfBirth { get; set; }
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand SignUpCommand { get; set; }
        public ICommand SignInCommand { get; set; }
        

        #endregion

        #region Constructor

        public SignUpViewModel(MainWindowViewModel baseVM)
        {
            this.baseVM = baseVM;

            SignUpCommand = new RelayCommand(Register);
            SignInCommand = new RelayCommand(baseVM.SwitchToSignIn);
        }

        #endregion

        #region Private methods

        private void Register() => Authorization.SignUp(LastName, FirstName, Patronymic, DateOfBirth, CardID, Password1, Password2);

        #endregion


        private void Clear()
        {
            Password1 = "";
            Password2 = "";
        }

        
    }
}
