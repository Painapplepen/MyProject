using InnoflowServer.Domain.Core.Entities;
using InnoflowServer.Domain.Interfaces.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoflowServer.Infrastructure.Data.Users
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext db;
        public UserRepository(ApplicationDbContext context)
        {
            db = context;
        }
        public IEnumerable<User> GetUsers()
        {
            return db.Users;
        }

        public User GetUser(int id)
        {
            return db.Users.Find(id);
        }

        public void CreateUser(User user)
        {
            db.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }
    
    }
}
