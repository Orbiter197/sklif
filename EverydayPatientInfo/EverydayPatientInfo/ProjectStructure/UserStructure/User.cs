using System;

namespace EverydayPatientInfo.ProjectStructure.UserStructure
{
    /// <summary>
    /// This class contains all data about user
    /// </summary>
    class User
    {
        #region Private fields

        /// <summary>
        /// First name, patronymic and last name of a user
        /// </summary>
        private UserNaming name;

        /// <summary>
        /// User's cardID
        /// </summary>
        private string login;

        #endregion

        #region Public properties

        /// <summary>
        /// First name, patronymic and last name of a user
        /// </summary>
        public UserNaming Name { get => name; private set => name = value; }

        /// <summary>
        /// User's cardID
        /// </summary>
        public string Login { get => login; private set => login = value; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs a User and initialise its fields
        /// </summary>
        /// <param name="name">First name, patronymic and last name of a user</param>
        /// <param name="type">User's cardID</param>
        /// <param name="login">Current role of user</param>
        protected User(UserNaming name, string login) 
        {
            this.Name = name;
            this.Login = login;
        }

        #endregion

        #region Private methods

        #endregion

        #region Public methods

        /// <summary>
        /// Registers a user in aa database
        /// </summary>
        /// <param name="firstName">User's first name</param>
        /// <param name="patronymic">User's patronymic</param>
        /// <param name="lastName">User's last name</param>
        /// <param name="login">User's cardID</param>
        /// <param name="password">User's password</param>
        /// <param name="number">User's telephone number</param>
        /// <returns>User</returns>
        public static User Register(
                string firstName,
                string patronymic,
                string lastName,
                string login,
                HashCode password,
                string number)
        {
            // TODO: send info
            return new User(new UserNaming(firstName, patronymic, lastName), login);

        }

        /// <summary>
        /// Finds user in database
        /// </summary>
        /// <param name="login"></param>
        /// <returns>User</returns>
        public static User FindByLogin(string login)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
