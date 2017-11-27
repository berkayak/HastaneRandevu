using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class HastaneMap : EntityTypeConfiguration<Hastane>
    {
        public HastaneMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Adi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Hastane");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.IlID).HasColumnName("IlID");
            this.Property(t => t.IlceID).HasColumnName("IlceID");

            // Relationships
            this.HasOptional(t => t.Il)
                .WithMany(t => t.Hastanes)
                .HasForeignKey(d => d.IlID);
            this.HasOptional(t => t.Ilce)
                .WithMany(t => t.Hastanes)
                .HasForeignKey(d => d.IlceID);

        }
    }
}
