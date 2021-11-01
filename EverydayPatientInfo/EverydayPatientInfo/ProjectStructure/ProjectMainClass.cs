namespace EverydayPatientInfo.ProjectStructure
{

    public static class ProjectMainClass
    {
        public static int? UserID { get => Authorization.UserID; }
        public static int? Role { get; set; }

        static ProjectMainClass()
        {
            Role = null;
        }

    }
}
