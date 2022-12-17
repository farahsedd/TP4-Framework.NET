using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using tp4_.net.Models;

namespace tp4_.net.Data
{
    public class UniversityContext : DbContext
    {
        public static UniversityContext _instance= null;
        private UniversityContext(DbContextOptions o): base(o) { }
        public static UniversityContext Instantiate_UniversityContext()
        {
            if (_instance == null) { 
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite(@"Data Source =C:\Users\katko\Documents\GL3\Frameworks et dev\TP\tp4 .net\tp4 .net\2022 GL3 .NET Framework TP4 - SQLite database.db");
            _instance= new UniversityContext(optionsBuilder.Options);
            Debug.WriteLine("on a instancié un nouveau universityContext");
            }
            return _instance;
        }
        public DbSet<Student> Student { get; set; }
    }
}
