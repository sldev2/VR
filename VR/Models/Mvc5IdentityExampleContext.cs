using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VR.Models.Mapping;

namespace VR.Models
{
    public partial class Mvc5IdentityExampleContext : DbContext
    {
        static Mvc5IdentityExampleContext()
        {
            Database.SetInitializer<Mvc5IdentityExampleContext>(null);
        }

        public Mvc5IdentityExampleContext()
            : base("Name=Mvc5IdentityExampleContext")
        {
        }

        public DbSet<CampaignPhas> CampaignPhases { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<ClaimData> ClaimDatas { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DefaultPledge> DefaultPledges { get; set; }
        public DbSet<ExternalLogin> ExternalLogins { get; set; }
        public DbSet<GovernmentLevel> GovernmentLevels { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Opponent> Opponents { get; set; }
        public DbSet<PledgeCommitment> PledgeCommitments { get; set; }
        public DbSet<PosseMembershipDetail> PosseMembershipDetails { get; set; }
        public DbSet<Poss> Posses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Verification> Verifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampaignPhasMap());
            modelBuilder.Configurations.Add(new CampaignMap());
            modelBuilder.Configurations.Add(new ClaimDataMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DefaultPledgeMap());
            modelBuilder.Configurations.Add(new ExternalLoginMap());
            modelBuilder.Configurations.Add(new GovernmentLevelMap());
            modelBuilder.Configurations.Add(new HouseMap());
            modelBuilder.Configurations.Add(new OpponentMap());
            modelBuilder.Configurations.Add(new PledgeCommitmentMap());
            modelBuilder.Configurations.Add(new PosseMembershipDetailMap());
            modelBuilder.Configurations.Add(new PossMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new TargetMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new VerificationMap());
        }
    }
}
