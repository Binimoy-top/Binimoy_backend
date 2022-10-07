using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test111binimoy.Models;

namespace test111binimoy.App_Code
{
    public class TestDbIntialization: DropCreateDatabaseAlways<TestDbContext>
    {
        protected override void Seed(TestDbContext context)
        {
            var users = new List<Users>
            {
        new Users {username="Noman",  Password="123456", email="2asd"},
        new Users {username="Shorif",  Password="123456", email="2asd"},
        new Users {username="Siam",  Password="123456", email="2asd"},
        new Users {username="Admin",  Password="123456", email="2asd"},
        new Users {username="admin",  Password="admin1234", email="2asd"},


      };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}