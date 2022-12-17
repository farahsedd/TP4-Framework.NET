using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Linq;
using tp4_.net.Data;
using tp4_.net.Models;

namespace tp4_.net.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
        }
        public IActionResult Courses()
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository sr = new StudentRepository(universityContext);
            IEnumerable<String> s = sr.GetCourses();
            return View(s);
        }
        public IActionResult GetStudentsByCourse(string c)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            StudentRepository sr = new StudentRepository(universityContext);
            IEnumerable<Student> students = (IEnumerable<Student>)sr.Find(s => s.course.ToLower() == c.ToLower());
            ViewBag.course = c;
            if (students.Count() == 0) { ViewBag.NotFound = true; }
            return View(students);

        }
    }
}
