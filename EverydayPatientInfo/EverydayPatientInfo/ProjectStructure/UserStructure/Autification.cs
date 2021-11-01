using System;

namespace EverydayPatientInfo.ProjectStructure.UserStructure
{
    /// <summary>
    /// THis class handles the autification
    /// </summary>
    public static class Autification
    {
        #region Public properties

        /// <summary>
        /// Current account that is in use
        /// </summary>
        public static string CurrentUser { get; private set; }

        /// <summary>
        /// Chechs if current user is not null
        /// </summary>
        public static bool IsAutificated => CurrentUser != null;

        #endregion

        #region Static constructor

        /// <summary>
        /// Static constructor for autification
        /// </summary>
        static Autification()
        {
            CurrentUser = null;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Finds a user 
        /// </summary>
        public static void SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Registrates a user in a Data Table
        /// </summary>
        public static void Register(string username, string password, string firstName, string patronymic, string lastName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds a user 
        /// </summary>
        public static void ResetPassword(string username, string newPassword)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
