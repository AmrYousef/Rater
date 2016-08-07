using Rater.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rater.WriteModel.Config
{
    public class RatingAttributeConfig : EntityTypeConfiguration<RatingAttribute>
    {
        public RatingAttributeConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.FreeTextRatingCategoryValue)
                .HasMaxLength(200);

            // Table & Column Configpings
            ToTable("RatingAttributes", "Rater");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.RatingAttributeCategoryValue).HasColumnName("RatingAttributeCategoryValue");
            Property(t => t.RatingId).HasColumnName("RatingId");
            Property(t => t.FreeTextRatingCategoryValue).HasColumnName("FreeTextRatingCategoryValue");

            // Relationships
            HasRequired(t => t.Rating)
                .WithMany(t => t.RatingAttributes)
                .HasForeignKey(d => d.RatingId);
            HasOptional(t => t.RatingattributeCategoryValue1)
                .WithMany(t => t.RatingAttributes)
                .HasForeignKey(d => d.RatingAttributeCategoryValue);
        }
    }
}