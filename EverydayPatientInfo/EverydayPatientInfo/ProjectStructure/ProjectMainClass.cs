using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.ProjectStructure
{

    public static class ProjectMainClass
    {
        #region Private fields

        private static string cardID = null;
        private static string lastName = null;
        private static string firstName = null;
        private static string patronymic = null;
        private static int? role = null;

        #endregion

        #region Public properties

        public static int? UserID { get => Authorization.UserID; }
        public static bool Access { get => Authorization.Access; }
        public static string CardID { get { return cardID; } }
        public static string LastName { get { return lastName; } }
        public static string FirstName { get { return firstName; } }
        public static string Patronymic { get { return patronymic; } }
        public static int? Role { get { return role; } }

        #endregion

        
        public static string DisplayedRole 
        {
            get => Role switch
            {
                1 => "Doctor",
                2 => "Operator",
                _ => "Not assigned"
            };
        }

        static ProjectMainClass()
        {

        }

        public static void Update()
        {
            MySqlCommand command = new("SELECT * FROM employees WHERE id = @id;", DataBaseHandler.Connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = UserID;

            DataBaseHandler.Open();
            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();
            cardID      = (reader.IsDBNull(1)) ? null : reader.GetFieldValue<string>(1);
            lastName    = (reader.IsDBNull(3)) ? null : reader.GetFieldValue<string>(3);
            firstName   = (reader.IsDBNull(4)) ? null : reader.GetFieldValue<string>(4);
            patronymic  = (reader.IsDBNull(5)) ? null : reader.GetFieldValue<string>(5);
            role        = (reader.IsDBNull(6)) ? null : reader.GetFieldValue<int>(6);
            reader.Close();

            DataBaseHandler.Close();
        }

        public static void SwitchRole(int roleID)
        {
            
        }

    }
}
