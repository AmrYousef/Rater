using Rater.Core.ReadModelData.Response;
using System.Data.Entity.ModelConfiguration;

namespace Rater.ReadModel.Config
{
    public class FieldReponseConfig : EntityTypeConfiguration<RatingFieldReponse>
    {
        public FieldReponseConfig()
        {
            ToTable("vRatingField", "Rater");
            // Primary Key
            HasKey(t => t.FieldId);

            // Properties
            Property(t => t.FieldName).HasColumnName("FieldName");
            Property(t => t.FieldId).HasColumnName("FieldId");
        }
    }
}