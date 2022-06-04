using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TEJADA_T3.Models.Map
{
    public class SexoMap : IEntityTypeConfiguration<Sexo>
    {
        public void Configure(EntityTypeBuilder<Sexo> builder)
        {
            builder.ToTable("Sexo");
            builder.HasKey(o => o.Id);
        }
    }
}
