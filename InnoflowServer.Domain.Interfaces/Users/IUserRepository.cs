using InnoflowServer.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace InnoflowServer.Domain.Interfaces.Users
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void CreateUser(User user);

        User GetUser(int id);

        void UpdateUser(User user);

        void DeleteUser(int id);

        //int CheckIfSameEmailExists(string email);
    }
}
