using System.Collections.Generic;

namespace InnoflowServer.Domain.Core.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<UserJobCategorie> UserJobCategories { get; set; }
        public User()
        {
            UserJobCategories = new List<UserJobCategorie>();
        }
    }
}
