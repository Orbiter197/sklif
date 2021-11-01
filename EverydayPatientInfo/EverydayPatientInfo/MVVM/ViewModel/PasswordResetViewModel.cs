using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PasswordResetViewModel : ObservableObject
    {

        #region Public properties
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand ResetPasswordCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        #endregion

        #region Constructor
        public PasswordResetViewModel()
        {
            Instances.PasswordResetVMInstance = this;

            ResetPasswordCommand = new RelayCommand(Reset);
            LoginCommand = new RelayCommand(ToLoginPage);
        }
        #endregion

        #region Private methods

        private void Reset()
        {
            bool state = Authorization.ResetPassword(CardID, Password1, Password2);
            if (state)
                ToLoginPage();
            else
                Clear();
        }

        private void Clear()
        {
            Password1 = "";
            Password2 = "";
        }

        private void ToLoginPage()
        {
            Instances.MainWindowVMInstance.CurrentView = Instances.SignInVMInstance;
        }
        #endregion



    }
}
