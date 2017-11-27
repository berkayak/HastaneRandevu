using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class KisilerMap : EntityTypeConfiguration<Kisiler>
    {
        public KisilerMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ad)
                .HasMaxLength(50);

            this.Property(t => t.Soyad)
                .HasMaxLength(50);

            this.Property(t => t.eMail)
                .HasMaxLength(50);

            this.Property(t => t.Parola)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Kisiler");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Ad).HasColumnName("Ad");
            this.Property(t => t.Soyad).HasColumnName("Soyad");
            this.Property(t => t.TC).HasColumnName("TC");
            this.Property(t => t.eMail).HasColumnName("eMail");
            this.Property(t => t.DogumTarihi).HasColumnName("DogumTarihi");
            this.Property(t => t.Cinsiyet).HasColumnName("Cinsiyet");
            this.Property(t => t.Parola).HasColumnName("Parola");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
        }
    }
}
