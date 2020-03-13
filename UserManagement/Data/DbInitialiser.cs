using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class DbInitialiser
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{FirstName="John",LastName="Smith",Title="Mr", Phone="1234567890"},
            new User{FirstName="Sheela",LastName="Santhosh",Title="Ms", Phone="1234567890"},
            new User{FirstName="David",LastName="Johnson",Title="Mr", Phone="1234567890"},
            new User{FirstName="Steven",LastName="Warner",Title="Mr", Phone="1234567890"},
            new User{FirstName="Dan",LastName="Brown",Title="Mr", Phone="1234567890"},
            };
            foreach (User user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}
