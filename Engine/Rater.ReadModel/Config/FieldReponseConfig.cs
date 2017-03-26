using Rater.Core.ReadModelData.Response;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Rater.ReadModel.Config
{
    public class FieldReponseConfig //: EntityTypeConfiguration<RatingFieldReponse>
    {
        public static void Configure(EntityTypeBuilder<RatingFieldReponse> builder)
        {
            builder.ToTable("vRatingField", "Rater");
            // Primary Key
            builder.HasKey(t => t.FieldId);

            // Properties
            builder.Property(t => t.FieldName).HasColumnName("FieldName");
            builder.Property(t => t.FieldId).HasColumnName("FieldId");
        }
    }
}