using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// The view model for Regestration Window and <see cref="RegisterationModel"/>
    /// </summary>
    class RegisterationViewModel : ObservableObject
    {
        #region Private fields

        /// <summary>
        /// The model of Register window
        /// </summary>
        private RegisterationModel registerationModel;

        #endregion

        #region Public properties

        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LastName { get; set; }
        public string CardID { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }

        public ICommand RegisterCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        #endregion

        

        private void Register()
        {
            if (Password1 != Password2)
                Clear();
            else if (registerationModel.Register(CardID, Password1))
                ToLoginPage();
            else
                Clear();

        }

        private void Clear()
        {
            Password1 = "";
            Password2 = "";
        }

        private void ToLoginPage()
        {
             Instances.MainWindowVMInstance.CurrentView = Instances.SignInVMInstance;
        }

        #region Constructor

        public RegisterationViewModel()
        {
            Instances.RegisterationVMInstance = this;

            registerationModel = new(this);

            RegisterCommand = new RelayCommand(Register);
            LoginCommand = new RelayCommand(ToLoginPage);
        }
        
        #endregion
    }
}
