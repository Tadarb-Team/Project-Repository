using System.ComponentModel.DataAnnotations;

namespace TEST2.Models.ViewModels
{
    public class StudentFull
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentUniversityId { get; set; }
    
        public string GPA { get; set; }
       
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public int CollegeId { get; set; }


        public string CollegeName { get; set; }

      
        public int OrganizationId { get; set; }

        public string OrganizationName { get; set; }
    }
}
