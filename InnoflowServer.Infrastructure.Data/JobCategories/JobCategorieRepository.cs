using InnoflowServer.Domain.Core.Entities;
using InnoflowServer.Domain.Interfaces.JobCategories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoflowServer.Infrastructure.Data.JobCategories
{
    public class JobCategorieRepository : IJobCategotieRepository
    {

        private ApplicationDbContext db;
        public JobCategorieRepository(ApplicationDbContext context)
        {
            db = context;
        }
        public IEnumerable<JobCategorie> GetJobCategories()
        {
            return db.JobCategories;
        }

        public JobCategorie GetJobCategorie(int id)
        {
            return db.JobCategories.Find(id);
        }

        public void CreateJobCategorie(JobCategorie jobCategorie)
        {
            db.JobCategories.Add(jobCategorie);
        }

        public void UpdateJobCategorie(JobCategorie jobCategorie)
        {
            db.Entry(jobCategorie).State = EntityState.Modified;
        }

        public void DeleteJobCategorie(int id)
        {
            JobCategorie jobCategorie = db.JobCategories.Find(id);
            if (jobCategorie != null)
                db.JobCategories.Remove(jobCategorie);
        }

    }
}
