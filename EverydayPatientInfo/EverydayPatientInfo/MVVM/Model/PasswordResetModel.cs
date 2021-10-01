using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.ViewModel;

namespace EverydayPatientInfo.MVVM.Model
{
    class PasswordResetModel
    {
        private PasswordResetViewModel passwordResetVM;

        public bool ResetPassword(string CardID, string Password)
        {
            if (false) // if person with card id was found in database
                return true;
            return false;
        }

        public PasswordResetModel(PasswordResetViewModel passwordResetVM)
        {
            this.passwordResetVM = passwordResetVM;
        }
    }
}
