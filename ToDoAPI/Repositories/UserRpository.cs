using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoDataAccess.Interfaces;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUser(string email, string password)
        {
            using (var dbContext = new ToDoContext())
            {
                return dbContext.Users.FirstOrDefault((x) => x.Email == email && x.Password == password);
            }
        }

        public void AddUser(User newUser)
        {
            using (var dbContext = new ToDoContext())
            {
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
            }
        }


    }
}
