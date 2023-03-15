using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST2.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }

        [Required]
        public string OrganizationName { get; set; }

        [Required]
        public int OrganizationTypeId { get; set; }

        [ForeignKey("OrganizationTypeId")]
        OrganizationType organizationType { get; set; }
    }
}
