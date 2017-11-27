using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class PoliklinikMap : EntityTypeConfiguration<Poliklinik>
    {
        public PoliklinikMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Adi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Poliklinik");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.HastaneID).HasColumnName("HastaneID");

            // Relationships
            this.HasOptional(t => t.Hastane)
                .WithMany(t => t.Polikliniks)
                .HasForeignKey(d => d.HastaneID);

        }
    }
}
