namespace EverydayPatientInfo.ProjectStructure
{

    public static class ProjectMainClass
    {
        public static int? UserID { get => Authorization.UserID; }
        public static int Role { get; set; }
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
            Role = 0;
        }

    }
}
