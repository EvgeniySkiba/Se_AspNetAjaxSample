using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SE_Asp_Net_Ajax.Models;

namespace SE_Asp_Net_Ajax.Utils
{
    //CarService 
    public class UserUtils
    {
        public static List<User> usersList { get; set; }


        static UserUtils()
        {
            usersList = new List<User>();
            createUserList();
        }

        #region  create fake data
        public static void createUserList()
        {

            var user = new User()
            {
                Id = 1,
                Email = "chernikov@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };
            var user2 = new User()
            { 
                Id = 2,
                Email = "chernikov@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };

            var user3 = new User()
            {
                Id = 3,
                Email = "chernikov3@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };

            var user4 = new User()
            {
                Id = 4,
                Email = "chernikov@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };

            var user5 = new User()
            {
                Id = 5,
                Email = "chernikov5@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };

            var user6 = new User()
            {
                Id = 6,
                Email = "chernikov6@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "M"
            };

            var user7 = new User()
            {
                Id = 7,
                Email = "chernikov@gmail.com",
                Name = "Andrey",
                FirstName = "Andrey",
                MiddleName = "Alexandrovich",
                LastName = "Chernikov",
                Gender = "F"
            };

            usersList.Add(user);
            usersList.Add(user2);
            usersList.Add(user3);
            usersList.Add(user4);
            usersList.Add(user5);
            usersList.Add(user6);
            usersList.Add(user7);
        }



        #endregion


        public static void AddUser(int id, string email, string gender, string name, string midleName, string lastName, string firstName)
        {
            usersList.Add(new User() { Id = id, Email = email, FirstName = firstName, Gender = gender, LastName = lastName, MiddleName = midleName, Name = name });
        }

        public static void AddUser(User user)
        {
            usersList.Add(user);
        }
    }
}