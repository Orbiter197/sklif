using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PasswordResetViewModel : ObservableObject
    {
        #region Private fields

        private PasswordResetModel passwordResetModel;

        #endregion

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
            passwordResetModel = new(this);

            ResetPasswordCommand = new RelayCommand(Reset);
            LoginCommand = new RelayCommand(ToLoginPage);
        }
        #endregion

        #region Private methods

        private void Reset()
        {
            if (Password1 != Password2)
                Clear();
            else if (passwordResetModel.ResetPassword(CardID, Password1))
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
            MainWindowViewModel.Instance.CurrentView = MainWindowViewModel.Instance.SignInVM;
        }
        #endregion



    }
}
