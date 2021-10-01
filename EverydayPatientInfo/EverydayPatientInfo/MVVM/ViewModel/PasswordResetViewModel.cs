using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class PasswordResetViewModel : ObservableObject
    {
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand ResetPassword { get; set; }
        public ICommand ToLoginPage { get; set; }

        public PasswordResetViewModel()
        {

        }

        
    }
}
