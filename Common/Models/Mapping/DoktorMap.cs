using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class DoktorMap : EntityTypeConfiguration<Doktor>
    {
        public DoktorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ad)
                .HasMaxLength(50);

            this.Property(t => t.Soyad)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Doktor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Ad).HasColumnName("Ad");
            this.Property(t => t.Soyad).HasColumnName("Soyad");
            this.Property(t => t.PoliklinikID).HasColumnName("PoliklinikID");

            // Relationships
            this.HasOptional(t => t.Poliklinik)
                .WithMany(t => t.Doktors)
                .HasForeignKey(d => d.PoliklinikID);

        }
    }
}
