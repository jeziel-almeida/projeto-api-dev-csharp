using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlines.EntityConfigurations
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            // Definindo a tabela
            builder.ToTable("Logins");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Usuario)
                    .IsRequired()
                    .HasMaxLength(40);
            builder.Property(l => l.Senha)
                    .IsRequired()
                    .HasMaxLength(12);
            builder.Property(l => l.DataCriacao)
                    .IsRequired();

        }
        
    }
}