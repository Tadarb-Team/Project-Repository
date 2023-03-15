using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST2.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }


        [Required]
        public string DepartmentName { get; set; }


        [Required]
        public int CollegeId { get; set; }

        [ForeignKey("CollegeId")]
        College college { get; set; }

    }
}
