using System.Linq.Expressions;
using tp4_.net.Models;

namespace tp4_.net.Data
{
    public class StudentRepository :IStudentRepository<Student>
    {
        private readonly UniversityContext _context;
        public StudentRepository(UniversityContext ctx)
        {
            _context = ctx;
        }
        public Student Get(int id)
        {
            return _context.Set<Student>().Find(id);
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.Set<Student>().ToList();
        }
        public IEnumerable<Student> Find(Expression<Func<Student, bool>> predicate)
        {
            return _context.Set<Student>().Where(predicate);
        }
        public bool Add(Student entity)
        {
             _context.Set<Student>().Add(entity);
            _context.SaveChanges();
            return true;
        }
        public bool Remove(Student entity)
        {
            _context.Set<Student>().Remove(entity);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<String> GetCourses()
        {
            return _context.Student.Select(s => s.course).Distinct().ToList();
        }
        
    }
}
