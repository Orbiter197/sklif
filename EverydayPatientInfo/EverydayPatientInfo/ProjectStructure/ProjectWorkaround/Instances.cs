﻿using EverydayPatientInfo.MVVM.ViewModel;
using System;

namespace EverydayPatientInfo.ProjectStructure.ProjectWorkaround
{
    [Obsolete()]
    static class Instances
    {

        public static string CardID { get; set; }
        public static string Name { get; set; }
        

        public static PasswordResetViewModel PasswordResetVMInstance { get; set; }

        public static NotAssignedViewModel NotAssignedVM { get; set; }
        public static DoctorViewModel DoctorVM { get; set; }
        public static OperatorViewModel OperatorVM { get; set; }
        public static ChangeRoleViewModel ChangeRoleVM { get; set; }
        public static SettingsViewModel SettingsVM { get; set; }


    }
}
