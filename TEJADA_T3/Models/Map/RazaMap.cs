using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TEJADA_T3.Models.Map
{
    public class RazaMap : IEntityTypeConfiguration<Raza>
    {
        public void Configure(EntityTypeBuilder<Raza> builder)
        {
            builder.ToTable("Raza");
            builder.HasKey(o => o.Id);
        }
    }
}
