using System.Collections.Generic;

namespace InnoflowServer.Domain.Core.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
