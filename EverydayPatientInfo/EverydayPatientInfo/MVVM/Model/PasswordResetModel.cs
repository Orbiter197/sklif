using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.Model
{
    class PasswordResetModel
    {
        private PasswordResetViewModel passwordResetVM;

        public bool ResetPassword(string CardID, string Password)
        {
            if (Instances.CardID != CardID)
                return false;

            Instances.CardID = CardID;
            return true;
        }

        public PasswordResetModel(PasswordResetViewModel passwordResetVM)
        {
            //this.passwordResetVM = passwordResetVM;
        }
    }
}
