using System;
using System.Collections.Generic;
using System.Text;
using ToDoDataAccess.Models;

namespace ToDoDataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(string email, string password);

        void AddUser(User user);
    }
}
