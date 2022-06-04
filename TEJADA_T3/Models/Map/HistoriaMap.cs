﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TEJADA_T3.Models.Map
{
    public class HistoriaMap : IEntityTypeConfiguration<Historia>
    {
        public void Configure(EntityTypeBuilder<Historia> builder)
        {
            builder.ToTable("Historia");
            builder.HasKey(o => o.Codigo);

            builder.HasOne(o => o.Sexo)
                .WithMany()
                .HasForeignKey(o => o.IdSexo);

            builder.HasOne(o => o.Especie)
                .WithMany()
                .HasForeignKey(o => o.IdEspecie);

            builder.HasOne(o => o.Raza)
                .WithMany()
                .HasForeignKey(o => o.IdRaza);
        }
    }
}
