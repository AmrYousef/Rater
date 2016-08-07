using Framework.EntityFramework;
using Rater.WriteModel.Config;
using System.Data.Entity;

namespace Rater.WriteModel
{
    public class RaterWriteContext : BaseWriteContext
    {
        static RaterWriteContext()
        {
            Database.SetInitializer<RaterWriteContext>(null);
        }

        public RaterWriteContext()
            : base("RaterWriteConnection")
        {
        }

        //public DbSet<Country> Countries { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Rating> Ratings { get; set; }
        //public DbSet<RatingAspect> RatingAspects { get; set; }
        //public DbSet<RatingattributeCategory> RatingattributeCategories { get; set; }
        //public DbSet<RatingattributeCategoryValue> RatingattributeCategoryValues { get; set; }
        //public DbSet<RatingAttribute> RatingAttributes { get; set; }
        //public DbSet<RatingField> RatingFields { get; set; }
        //public DbSet<RatingReply> RatingReplies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new RatingConfig());
            modelBuilder.Configurations.Add(new RatingAspectConfig());
            modelBuilder.Configurations.Add(new RatingattributeCategoryConfig());
            modelBuilder.Configurations.Add(new RatingattributeCategoryValueConfig());
            modelBuilder.Configurations.Add(new RatingAttributeConfig());
            modelBuilder.Configurations.Add(new RatingFieldConfig());
            modelBuilder.Configurations.Add(new RatingReplyConfig());
        }
    }
}