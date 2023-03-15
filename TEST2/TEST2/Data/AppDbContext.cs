using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TEST2.Models;
using TEST2.Models.ViewModels;
namespace TEST2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {



        }
        // الجدول الذي سيتم انشاءه داخل الداتا بيس  بناء على المودل بستخدام امر ال
        public DbSet<Organization> Organizations { get; set; }

        public  DbSet<OrganizationType> OrganizationsType { get; set; }

        public DbSet<College> Colleges { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }


        public DbSet<StudentFull> StudentsFull { get; set; }
    }

}








