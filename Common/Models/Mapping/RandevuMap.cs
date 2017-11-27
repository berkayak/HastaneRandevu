using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class RandevuMap : EntityTypeConfiguration<Randevu>
    {
        public RandevuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Randevu");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HastaID).HasColumnName("HastaID");
            this.Property(t => t.HastaneID).HasColumnName("HastaneID");
            this.Property(t => t.PoliklinikID).HasColumnName("PoliklinikID");
            this.Property(t => t.RandevuTarihi).HasColumnName("RandevuTarihi");
            this.Property(t => t.OlusturulmaTarihi).HasColumnName("OlusturulmaTarihi");

            // Relationships
            this.HasOptional(t => t.Kisiler)
                .WithMany(t => t.Randevus)
                .HasForeignKey(d => d.HastaID);
            this.HasOptional(t => t.Poliklinik)
                .WithMany(t => t.Randevus)
                .HasForeignKey(d => d.PoliklinikID);

        }
    }
}
