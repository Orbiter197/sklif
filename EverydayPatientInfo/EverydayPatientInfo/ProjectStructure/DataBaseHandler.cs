using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.ProjectStructure
{
    /// <summary>
    /// Allows to connect to the Database
    /// </summary>
    static class DataBaseHandler
    {
        #region Private fields

        /// <summary>
        /// Connection to the Database
        /// </summary>
        private static MySqlConnection connection;

        #endregion

        #region Constructor

        /// <summary>
        /// Sets default values
        /// </summary>
        static DataBaseHandler()
        {
            connection = new("Server=localhost; Port=3306; Username=global; Password=global_pass; Database=everyday_patient_info");
        }

        #endregion

        #region Operators

        /// <summary>
        /// Opens connection
        /// </summary>
        public static void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        /// <summary>
        /// Closes connection
        /// </summary>
        public static void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        /// <summary>
        /// Connection to the Database
        /// </summary>
        public static MySqlConnection Connection { get => connection; }

        #endregion
    }
}
