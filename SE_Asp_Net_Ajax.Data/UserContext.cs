using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE_Asp_Net_Ajax.Data.Entities;

namespace SE_Asp_Net_Ajax.Data
{
    public class UserContext : DbContext
    {
        static UserContext()
        {
            Database.SetInitializer<UserContext>(new MyContextInitializer());
        }


        public UserContext()
        { }

        public DbSet<User> Users { get; set; }
    }
}
