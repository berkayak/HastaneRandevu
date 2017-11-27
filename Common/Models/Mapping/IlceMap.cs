using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class IlceMap : EntityTypeConfiguration<Ilce>
    {
        public IlceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Adi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ilce");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.IlID).HasColumnName("IlID");

            // Relationships
            this.HasOptional(t => t.Il)
                .WithMany(t => t.Ilces)
                .HasForeignKey(d => d.IlID);

        }
    }
}
