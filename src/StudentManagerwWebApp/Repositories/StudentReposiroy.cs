using StudentManagerwWebApp.Models.Student;

namespace StudentManagerwWebApp.Repositories
{
    public class StudentReposiroy<T> : IRepository<T> where T : class, IEntity
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}