using Framework.EntityFramework;
using Rater.ReadModel.Config;
using System.Data.Entity;

namespace Rater.ReadModel
{
    public class RaterReadContext : BaseReadContext
    {
        static RaterReadContext()
        {
            Database.SetInitializer<RaterReadContext>(null);
        }

        public RaterReadContext()
            : base("RaterReadConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FieldReponseConfig());
        }
    }
}