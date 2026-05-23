using StudentManagerwWebApp.Models.Student;

namespace StudentManagerwWebApp.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Func<T, bool> predicate);
    }
}
