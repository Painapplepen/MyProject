using InnoflowServer.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoflowServer.Domain.Interfaces.JobCategories
{
    public interface IJobCategotieRepository
    {
        IEnumerable<JobCategorie> GetJobCategories();
        void CreateJobCategorie(JobCategorie jobCategorie);

        JobCategorie GetJobCategorie(int id);

        void UpdateJobCategorie(JobCategorie jobCategorie);

        void DeleteJobCategorie(int id);
    }
}
