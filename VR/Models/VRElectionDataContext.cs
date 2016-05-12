using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VR.Models.Mapping;

namespace VR.Models
{
    public partial class VRElectionDataContext : DbContext
    {
        static VRElectionDataContext()
        {
            Database.SetInitializer<VRElectionDataContext>(null);
        }

        public VRElectionDataContext()
            : base("Name=VRElectionDataContext")
        {
        }

        public DbSet<CongDem> CongDems { get; set; }
        public DbSet<freeZipcodeDb> freeZipcodeDbs { get; set; }
        public DbSet<PrezDem> PrezDems { get; set; }
        public DbSet<PrezRepub> PrezRepubs { get; set; }
        public DbSet<Target_TemplateInfo> Target_TemplateInfo { get; set; }
        public DbSet<USZipCode> USZipCodes { get; set; }
        public DbSet<USZipCodeFirst> USZipCodeFirsts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CongDemMap());
            modelBuilder.Configurations.Add(new freeZipcodeDbMap());
            modelBuilder.Configurations.Add(new PrezDemMap());
            modelBuilder.Configurations.Add(new PrezRepubMap());
            modelBuilder.Configurations.Add(new Target_TemplateInfoMap());
            modelBuilder.Configurations.Add(new USZipCodeMap());
            modelBuilder.Configurations.Add(new USZipCodeFirstMap());
        }
    }
}
