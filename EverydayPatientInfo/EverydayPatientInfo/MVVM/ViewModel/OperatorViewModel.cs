using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

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

        #region i,a,b
        public ICommand AddNewCommand { get; set; }

        public int state = 5;


        public string i2 { get; set; }
        public string i3 { get; set; }
        public string i4 { get; set; }
        public string i5 { get; set; }

        public string a1 { get; set; }
        public string a2 { get; set; }
        public string a3 { get; set; }
        public string a4 { get; set; }
        public string a5 { get; set; }

        public string b1 { get; set; }
        public string b2 { get; set; }
        public string b3 { get; set; }
        public string b4 { get; set; }
        public string b5 { get; set; }

        private void AddNew()
        {
            if (state == 5)
            {
                a1 = state.ToString();
                a2 = i2;
                a3 = i3;
                a4 = i4;
                a5 = i5;

            }
            else
            {
                b1 = state.ToString();
                b2 = i2;
                b3 = i3;
                b4 = i4;
                b5 = i5;
            }
            i2 = "";
            i3 = "";
            i4 = "";
            i5 = "";
            state++;
        }

        #endregion

        #region Find
        public ICommand FindCommand { get; set; }
        public string InputField { get; set; }
        public string HintField { get; set; }

        public void Find()
        {
            if (InputField == "Vad")
                HintField = "Vadim Kazanzev";
            else if (InputField == "Nata")
                HintField = "Nataliya Yakovleva";
            else
                HintField = "";
        }
        #endregion

        public OperatorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;

            AddNewCommand = new RelayCommand(AddNew);
            FindCommand = new RelayCommand(Find);
            #region Temp

            #endregion
        }
    }
}
