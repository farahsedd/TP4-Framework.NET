using System.Linq.Expressions;
using tp4_.net.Models;

namespace tp4_.net.Data
{
    public interface IStudentRepository<TEntity> where TEntity:class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        bool Add(TEntity entity);
        bool Remove(TEntity entity);
        IEnumerable<String> GetCourses();



    }
}
