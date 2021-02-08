using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models;
using WEB_agendaLanlink.Models.DataObject;
using WEB_agendaLanlink.Repositories.Configuration;

namespace WEB_agendaLanlink
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<TipoEndereco> tipoEnderecos { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            modelBuilder.Entity<TipoEndereco>().HasData(
                new TipoEndereco() { Id = 1, Descricao = "apartamento" },
                new TipoEndereco() { Id = 2, Descricao = "casa" },
                new TipoEndereco() { Id = 3, Descricao = "sitio" },
                new TipoEndereco() { Id = 4, Descricao = "galpao" }
           );

           base.OnModelCreating(modelBuilder);
        }
    }
}
