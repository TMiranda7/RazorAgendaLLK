using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models;
using WEB_agendaLanlink.Repositories.Contractors;

namespace WEB_agendaLanlink.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco> , IEnderecoRepository
    {
        public EnderecoRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
