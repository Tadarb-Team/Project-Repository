using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace TEST2.Models
{
    public class OrganizationType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        public string TypeName { get; set; }
    }
}
