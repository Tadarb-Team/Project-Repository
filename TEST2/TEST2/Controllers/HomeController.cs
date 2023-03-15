using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TEST2.Data;
using TEST2.Models;
using TEST2.Models.ViewModels;

namespace TEST2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<StudentFull> students = _dbContext.StudentsFull.FromSqlRaw("Select * from StudentsFull where StudentsFull.OrganizationName='جامعة طيبة'");

            return View(students);
        }

        public IActionResult StudntInfo()
        {


            return View();
        }


    }
}