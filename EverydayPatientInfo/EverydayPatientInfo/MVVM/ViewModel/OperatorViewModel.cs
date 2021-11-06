using System;
using System.Collections.Generic;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class OperatorViewModel : ObservableObject
    {
        #region Private fields

        private MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        #region Binding properties

        public List<Patient> PatientList { get; set; }

        #endregion

        public OperatorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
            List<Patient> p = new();
            for (int i = 0; i < 5; i++)
            {
                p.Add(new Patient
                {
                    ID = null,
                    Chamber = 1,
                    LastName = "Yanushkeevich " + (i + 1).ToString(),
                    FirstName = "Irina " + (i + 1).ToString(),
                    Patronymic = "Olegovna",
                    Data = new PatientJsonData
                    {
                        PressureEvening = Array.Empty<double>(),
                        PressureMorning = Array.Empty<double>(),
                        SugarEvening = Array.Empty<double>(),
                        SugarMorning = Array.Empty<double>(),
                        WeightEvening = Array.Empty<double>(),
                        WeightMorning = Array.Empty<double>(),
                        Height = Array.Empty<double>(),
                    },
                    Doctor_ID = ProjectMainClass.UserID
                }); ;
                PatientLogicHandler.Add(p[i]);
            }
            PatientList = p;
        }
    }


    
}
