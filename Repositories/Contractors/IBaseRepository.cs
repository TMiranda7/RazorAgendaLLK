using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_agendaLanlink.Repositories.Contractors
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Del(T entity);
        void Update(T entity);
        IEnumerable<T> ObterTodos();
        T ObterId(T entity);
    }
}
