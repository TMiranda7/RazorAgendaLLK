using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models;

namespace WEB_agendaLanlink.Repositories.Configuration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .HasKey(E => E.Id);

            builder
                .Property(P => P.nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(P => P.cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(P => P.enderecoId)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(P => P.Endereco)
                .WithOne();

            builder
                .Property(C => C.celular)
                .HasMaxLength(10);

            builder
                .Property(C => C.telefone)
                .HasMaxLength(10);

            builder
                .Property(C => C.email)
                .HasMaxLength(100);

            builder
                .Property(C => C.site)
                .HasMaxLength(100);
        }
    }
}
