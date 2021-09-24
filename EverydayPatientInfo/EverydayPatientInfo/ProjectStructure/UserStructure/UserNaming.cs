namespace EverydayPatientInfo.ProjectStructure.UserStructure
{
    /// <summary>
    /// This structure contains first name, patronymic and last name of a user
    /// </summary>
    struct UserNaming
    {
        #region Private fields

        /// <summary>
        /// User's first name 
        /// </summary>
        private string firstName;

        /// <summary>
        /// User's patronymic
        /// </summary>
        private string patronymic;

        /// <summary>
        /// User's last name
        /// </summary>
        private string lastName;

        #endregion

        #region Public properties

        /// <summary>
        /// User's first name 
        /// </summary>
        public string FirstName { get => firstName; private set => firstName = value; }

        /// <summary>
        /// User's patronymic
        /// </summary>
        public string Patronymic { get => patronymic; private set => patronymic = value; }

        /// <summary>
        /// User's last name
        /// </summary>
        public string LastName { get => lastName; private set => lastName = value; }

        #endregion

        #region Constructor
        /// <summary>
        /// Creates structure that contains first name, patronymic and last name of a user
        /// </summary>
        /// <param name="firstName">User's first name </param>
        /// <param name="patronymic">User's patronymic</param>
        /// <param name="lastName">User's last name</param>
        public UserNaming(string firstName, string patronymic, string lastName)
        {
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.lastName = lastName;
        }
        #endregion

    }
}
