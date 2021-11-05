using System;
using System.Collections.Generic;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;


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
                p.Add(new Patient("Sviridov " + i.ToString(), "Ilya " + i.ToString(), i + 30));
            }
            PatientList = p;
        }
    }


    
}
