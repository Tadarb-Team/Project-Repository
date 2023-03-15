using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TEST2.Models
{
    public class Student
    {


        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentUniversityId { get; set; }
        [Required]
        public string GPA { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        Department department { get; set; }
       
    }
}
