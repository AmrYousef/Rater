using Rater.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Rater.WriteModel.Config
{
    public class RatingFieldConfig //: EntityTypeConfiguration<RatingField>
    {
         public static void Configure(EntityTypeBuilder<RatingField> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Configpings
            builder.ToTable("RatingField", "Rater");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}