using Rater.Domain.Entities;

using System.Data.Entity.ModelConfiguration;

namespace Rater.WriteModel.Config
{
    public class CountryConfig : EntityTypeConfiguration<Country>
    {
        public CountryConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Configpings
            ToTable("Country", "Common");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");

            // Relationships
            HasMany(t => t.RatingattributeCategoryValues)
                .WithMany(t => t.Countries)
                .Map(m =>
                    {
                        m.MapLeftKey("CountryId");
                        m.MapRightKey("RatingAttributeCategoryValueId");
                        m.ToTable("RatingAttributeCategoryValueCountry", "Rater");
                    });
        }
    }
}