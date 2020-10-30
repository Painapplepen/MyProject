using System.Collections.Generic;

namespace InnoflowServer.Domain.Core.Entities
{
    public class JobCategorie : BaseEntity
    {
        public string Name { get; set; }
        public List<UserJobCategorie> UserJobCategories { get; set; }
        public JobCategorie()
        {
            UserJobCategories = new List<UserJobCategorie>();
        }
    }
}
