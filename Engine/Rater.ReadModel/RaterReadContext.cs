using Framework.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Rater.Core.ReadModelData.Response;
using Rater.ReadModel.Config;
//using System.Data.Entity;

namespace Rater.ReadModel
{
    public class RaterReadContext : BaseReadContext
    {
        //static RaterReadContext()
        //{
        //    Database.SetInitializer<RaterReadContext>(null);
        //}

        public RaterReadContext()
            : base(@"Data Source=.;Initial Catalog=RaterDB;Integrated Security=True;Pooling=False")
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FieldReponseConfig.Configure(modelBuilder.Entity<RatingFieldReponse>());
        }
    }
}