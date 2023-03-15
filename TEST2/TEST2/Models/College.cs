using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST2.Models
{
    public class College
    {
        [Key]
        public int CollegeId { get; set; }

        [Required]
        public string CollegeName { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [ForeignKey("OrganizationId")]
        Organization organization { get; set; }
    }


}
