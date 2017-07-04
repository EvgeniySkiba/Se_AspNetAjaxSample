using SE_Asp_Net_Ajax.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Asp_Net_Ajax.Data
{
    class MyContextInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
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

            db.Users.Add(user);
            db.Users.Add(user2);

            db.SaveChanges();
        }
    }
}
