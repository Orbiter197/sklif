using EverydayPatientInfo.MVVM.ViewModel;
using System;

namespace EverydayPatientInfo.ProjectStructure.ProjectWorkaround
{
    [Obsolete()]
    static class Instances
    {

        public static string CardID { get; set; }
        public static string Name { get; set; }

        public static DoctorViewModel DoctorVM { get; set; }
        public static OperatorViewModel OperatorVM { get; set; }
        public static RoleManagerViewModel ChangeRoleVM { get; set; }
        public static SettingsViewModel SettingsVM { get; set; }


    }
}
