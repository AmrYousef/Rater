using Rater.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rater.WriteModel.Config
{
    public class RatingFieldConfig : EntityTypeConfiguration<RatingField>
    {
        public RatingFieldConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Configpings
            ToTable("RatingField", "Rater");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}