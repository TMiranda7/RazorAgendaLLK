using System.Collections.Generic;
using System.Linq;
using WEB_agendaLanlink.Models;
using WEB_agendaLanlink.Repositories.Contractors;
using static WEB_agendaLanlink.Models.BaseModel;

namespace WEB_agendaLanlink.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T :class
    {
        protected readonly ApplicationContext context;
        public BaseRepository(ApplicationContext _context)
        {
            context = _context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Del(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
        public T ObterId(T entity)
        {
            return context.Set<T>().Find(entity);
        }
        public IEnumerable<T> ObterTodos()
        {
            return context.Set<T>().ToList();
        }
        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
