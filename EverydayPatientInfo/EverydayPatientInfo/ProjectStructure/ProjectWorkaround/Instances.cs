using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.DataBaseStructure;

namespace EverydayPatientInfo.ProjectStructure.ProjectWorkaround
{
    static class Instances
    {
        public static int CardID { get; set; }
        public static int Name { get; set; }
        public static int Role { get; set; }

        public static MainWindowViewModel MainWindowVMInstance { get; set; }
        public static MainWindowModel MainWindowModelInstance { get; set; }

        public static SignInViewModel SignInVMInstance { get; set; }
        public static SignInModel SignInModelInstance { get; set; }

        public static RegisterationViewModel RegisterationVMInstance { get; set; }
        public static RegisterationModel RegisterationModelInstance { get; set; }

        public static PasswordResetViewModel PasswordResetVMInstance { get; set; }
        public static PasswordResetModel PasswordResetModelInstance { get; set; }

        public static MainContentViewModel MainContentViewModelVMInstance { get; set; }
        //public static MainContentModel MainContentModelInstance { get; set; }


    }
}
