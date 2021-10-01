using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.DataBaseStructure;
using EverydayPatientInfo.ProjectStructure.UserStructure;

namespace EverydayPatientInfo.ProjectStructure.ProjectWorkaround
{
    static class Instances
    {
        private static UserType role = UserType.NotAssigned;

        public static string CardID { get; set; }
        public static string Name { get; set; }
        public static string Role
        { 
            get
            {
                return (int)role switch
                {
                    1 => "Doctor",
                    2 => "Operator",
                    _ => "Not assigned"
                };
            }
            set
            {
                role = value switch
                {
                    "Doctor"    => UserType.Doctor,
                    "Operator"  => UserType.Operator,
                    _           => UserType.NotAssigned
                };
            }
        } 

        


            

        public static MainWindowViewModel MainWindowVMInstance { get; set; }
        public static MainWindowModel MainWindowModelInstance { get; set; }

        public static SignInViewModel SignInVMInstance { get; set; }
        public static SignInModel SignInModelInstance { get; set; }

        public static RegisterationViewModel RegisterationVMInstance { get; set; }
        public static RegisterationModel RegisterationModelInstance { get; set; }

        public static PasswordResetViewModel PasswordResetVMInstance { get; set; }
        public static PasswordResetModel PasswordResetModelInstance { get; set; }

        public static MainContentViewModel MainContentVMInstance { get; set; }
        //public static MainContentModel MainContentModelInstance { get; set; }


    }
}
