using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.ProjectStructure
{
    public static class DB
    {
        private static MySqlConnection connection = new("Server=localhost; Port=3306; Username=global; Password=global_pass; Database=everyday_patient_info");

        public static void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public static MySqlConnection Connection { get => connection; }
    }
}
