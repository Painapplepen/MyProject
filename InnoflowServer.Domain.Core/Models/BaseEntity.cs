using System.ComponentModel.DataAnnotations;

namespace InnoflowServer.Domain.Core
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
