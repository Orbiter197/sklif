using System;

using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.UserStructure;

using System.Collections.Generic;
using System.Text;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.Model
{
    class RegisterationModel
    {
        #region Private fields

        /// <summary>
        /// The viewmodel of Register window
        /// </summary>
        private RegisterationViewModel registerationVM;

        #endregion

        #region Public fiels


        #endregion

        #region Public methods

        /// <summary>
        /// This method is used as a Command
        /// </summary>
        /// <param name="cardID"></param>
        /// <param name="password"></param>

        public bool Register(string cardID, string password)
        {
            Instances.CardID = cardID;
            return true;
        }



        #endregion

        #region Constructor

        public RegisterationModel(RegisterationViewModel registerationVM)
        {
            this.registerationVM = registerationVM;
        }

        #endregion
    }
}
