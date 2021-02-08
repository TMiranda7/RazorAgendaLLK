using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models;

namespace WEB_agendaLanlink.Repositories.Configuration
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
                .HasKey(E => E.Id);

            builder
                .Property(E => E.logradouro)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(E => E.numero)
                .IsRequired()
                .HasMaxLength(4);

            builder
                .Property(E => E.complemento)
                .HasMaxLength(100);

            builder
                .Property(E => E.bairro)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(E => E.cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(E => E.estado)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(E => E.cep)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(E => E.tipoEndereco)
                .IsRequired();
        }
    }
}
