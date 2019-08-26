using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// The model class of User containing properties needed for user to login
    /// </summary>
    public class User
    {
        private string username;
        private string password;
        private string userType;
        private string firstName;
        private string surName;
        private string dateOfBirth;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserType { get => userType; set => userType = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SurName { get => surName; set => surName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        // Checks if there is missing value in each property of model User
        public bool CheckEmptyFields()
        {
            if (username.Equals(string.Empty) || password.Equals(string.Empty) || userType.Equals(string.Empty) || firstName.Equals(string.Empty)
                || surName.Equals(string.Empty) || dateOfBirth.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }
    }
}
