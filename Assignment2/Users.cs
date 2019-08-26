using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment2
{
    /// <summary>
    /// The class with collection of users stored.
    /// This class performs all basic operation related to list of users.
    /// e.g. save a new user, load collection of users, etc.
    /// </summary>
    class Users
    {
        List<User> users;

        // This is a constructor of class users
        public Users()
        {
            users = new List<User>();
        }

        // Gets a collection of users
        public List<User> getUsers()
        {
            return users;
        }

        // Adds a new user to this a list of users
        public void AddUser(User newUser)
        {
            users.Add(newUser);
        }

        // Loads a collection of users from login.txt and stores it into 
        // a list of users
        public void LoadData()
        {
            string filepath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\LoginText\\login.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            List<User> users = new List<User>();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                User user = new User();

                user.Username = entries[0];
                user.Password = entries[1];
                user.UserType = entries[2];
                user.FirstName = entries[3];
                user.SurName = entries[4];
                user.DateOfBirth = entries[5];

                users.Add(user);
            }

            this.users = users;
        }

        // Saves a new user and add the new user information into login.txt
        public void SaveNewUser(User newUser)
        {
            string filepath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\LoginText\\login.txt";

            string newLine = string.Format("{0},{1},{2},{3},{4},{5}", newUser.Username,
                newUser.Password, 
                newUser.UserType, 
                newUser.FirstName, 
                newUser.SurName, 
                newUser.DateOfBirth);

            File.AppendAllText(filepath, string.Format("{0}{1}", Environment.NewLine, newLine));
        }

        // Checks if username is valid or not
        public bool CheckUsername(string username)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username))
                    return false;
            }
            return true;
        }

        // Checks if username and password is valid to login
        public User IsLoginSucceed(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username) && user.Password.Equals(password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
