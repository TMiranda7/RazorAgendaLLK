using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Repositories.Contractors;

namespace WEB_agendaLanlink
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IPessoaRepository pessoaRepository;

        public DataService(ApplicationContext _context, IPessoaRepository _pessoaRepository)
        {
            this.context = _context;
            this.pessoaRepository = _pessoaRepository;
        }

        public void IniciaDB()
        {
            context.Database.EnsureCreated();
        }
    }
}
