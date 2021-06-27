using CinemaManagment.Entities;

namespace CinemaManagment.Common
{
    public class User
    {
        private static User instance;

        public Employee e { get; set; }
        
        private User() {}

        public static User getInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }

            return instance;
        }
        
        public static Employee getEmployee()
        {
            return getInstance().e;
        }
    }
}