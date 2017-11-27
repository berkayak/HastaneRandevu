using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Common.Models.Mapping;
using Common.Models;


namespace Repository.Data
{
    public partial class HastaneRandevuContext : DbContext
    {
        static HastaneRandevuContext()
        {
            Database.SetInitializer<HastaneRandevuContext>(null);
        }

        public HastaneRandevuContext()
            : base("Name=HastaneRandevuContext")
        {
        }

        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hastane> Hastanes { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Kisiler> Kisilers { get; set; }
        public DbSet<Poliklinik> Polikliniks { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DoktorMap());
            modelBuilder.Configurations.Add(new HastaneMap());
            modelBuilder.Configurations.Add(new IlMap());
            modelBuilder.Configurations.Add(new IlceMap());
            modelBuilder.Configurations.Add(new KisilerMap());
            modelBuilder.Configurations.Add(new PoliklinikMap());
            modelBuilder.Configurations.Add(new RandevuMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
