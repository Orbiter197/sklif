using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;

using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PasswordResetViewModel : ObservableObject
    {
        #region Private fields

        private MainWindowViewModel baseVM;
        #endregion

        #region Public properties

        public MainWindowViewModel BaseVM { get => baseVM; }
        #endregion

        #region Public binding properties

        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand PasswordResetCommand { get; set; }
        public ICommand SignInCommand { get; set; }
        #endregion

        #region Constructor
        public PasswordResetViewModel(MainWindowViewModel baseVM)
        {
            this.baseVM = baseVM;

            PasswordResetCommand = new RelayCommand(Reset);
            SignInCommand = new RelayCommand(baseVM.SwitchToSignIn);
        }
        #endregion

        #region Private methods

        private void Reset()
        {
            bool state = Authorization.ResetPassword(CardID, Password1, Password2);
            if (state)
                baseVM.SwitchToSignIn();
            else
                Clear();
        }

        private void Clear()
        {
            Password1 = "";
            Password2 = "";
        }
        #endregion



    }
}
