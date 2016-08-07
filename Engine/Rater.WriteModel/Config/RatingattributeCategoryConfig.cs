using Rater.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rater.WriteModel.Config
{
    public class RatingattributeCategoryConfig : EntityTypeConfiguration<RatingattributeCategory>
    {
        public RatingattributeCategoryConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Configpings
            ToTable("RatingattributeCategory", "Rater");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.RatingFieldId).HasColumnName("RatingFieldId");

            // Relationships
            HasOptional(t => t.RatingField)
                .WithMany(t => t.RatingattributeCategories)
                .HasForeignKey(d => d.RatingFieldId);
        }
    }
}