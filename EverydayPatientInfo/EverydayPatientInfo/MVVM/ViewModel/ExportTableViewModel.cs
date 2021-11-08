using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.PatientStructure;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class ExportTableViewModel : ObservableObject
    {
        #region Private fields

        private DoctorViewModel baseVM;
        private List<Patient> list;

        #endregion

        #region Public properties

        public DoctorViewModel BaseVM { get => baseVM; }

        #endregion

        #region Binding properties

        public List<PatientExportParams> ParamsList {get; set;}
        public string SavingPath { get; set; }

        public ICommand SelectDefaultCommand { get; set; }
        public ICommand SaveAsDefaul { get; set; }
        public ICommand Export { get; set; }
        public ICommand GoBackCommand { get; set; }

        public ExportTableViewModel(DoctorViewModel baseVM, List<Patient> list)
        {
            this.baseVM = baseVM;
            this.list = list;

            ParamsList = PatientExportParams.GetList();
            SavingPath = "C:\\EverydayPatientInfoExportedExcels";

            SelectDefaultCommand = new RelayCommand(() => PatientExportParams.GetDefault(ParamsList));
            SaveAsDefaul = new RelayCommand(() => PatientExportParams.SetDefault(ParamsList));
            Export = new RelayCommand(CheckPath);
            GoBackCommand = new RelayCommand(baseVM.SwitchToTable);
        }   

        #endregion

        private void CheckPath()
        {
            if (ExcelExport.Export(this.list, SavingPath, "Exported table", ParamsList))
                baseVM.SwitchToTable();
            else
                SavingPath = "C:\\EverydayPatientInfoExportedExcels";
        }



    }
}
