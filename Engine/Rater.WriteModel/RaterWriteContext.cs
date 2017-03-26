using Framework.EntityFramework;
using Rater.WriteModel.Config;
using Microsoft.EntityFrameworkCore;
using Rater.Domain.Entities;

namespace Rater.WriteModel
{
    public class RaterWriteContext : BaseWriteContext
    {
        //static RaterWriteContext()
        //{
        //    Database.SetInitializer<RaterWriteContext>(null);
        //}

        public RaterWriteContext()
            : base(@"Data Source=.;Initial Catalog=RaterDB;Integrated Security=True;Pooling=False")
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CountryConfig.Configure(modelBuilder.Entity<Country>());
            RatingFieldConfig.Configure(modelBuilder.Entity<RatingField>());
            //modelBuilder.Configurations.Add(new UserConfig());
            //modelBuilder.Configurations.Add(new RatingConfig());
            //modelBuilder.Configurations.Add(new RatingAspectConfig());
            //modelBuilder.Configurations.Add(new RatingattributeCategoryConfig());
            //modelBuilder.Configurations.Add(new RatingattributeCategoryValueConfig());
            //modelBuilder.Configurations.Add(new RatingAttributeConfig());
            //modelBuilder.Configurations.Add(new RatingFieldConfig());
            //modelBuilder.Configurations.Add(new RatingReplyConfig());
        }
    }
}