using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class RegisterationViewModel : ObservableObject
    {

        #region Public properties

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public string DateOfBirth { get; set; }
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        public RegisterationViewModel()
        {
            Instances.RegisterationVMInstance = this;

            RegisterCommand = new RelayCommand(Register);
            LoginCommand = new RelayCommand(ToLoginPage);
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

        private void ToLoginPage()
        {
            Instances.MainWindowVMInstance.CurrentView = Instances.SignInVMInstance;
        }

        
    }
}
