using InnoflowServer.Domain.Core.Entities;
using InnoflowServer.Infrastructure.Data.JobCategories;
using InnoflowServer.Infrastructure.Data.Users;
using System;
using System.Collections.Generic;

namespace InnoflowServer.Infrastructure.Data
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext db;
        private UserRepository userRepository;
        private JobCategorieRepository jobCategorieRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            db = context;
        }
        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public JobCategorieRepository JobCategories
        {
            get
            {
                if (jobCategorieRepository == null)
                    jobCategorieRepository = new JobCategorieRepository(db);
                return jobCategorieRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
