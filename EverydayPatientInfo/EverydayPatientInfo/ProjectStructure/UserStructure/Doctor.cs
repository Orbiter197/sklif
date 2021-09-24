namespace EverydayPatientInfo.ProjectStructure.UserStructure
{
    class Doctor : User
    {

        protected Doctor(UserNaming name, string login) : base(name, login)
        {

        }

        public static Doctor UserToDoctor(User user)
        {
            if (user == null)
                throw new System.ArgumentNullException();

            if (false)
                throw new System.ArgumentException();

            return new Doctor(user.Name, user.Login);
        }
    }
}
