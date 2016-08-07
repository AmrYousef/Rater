using Rater.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rater.WriteModel.Config
{
    public class RatingConfig : EntityTypeConfiguration<Rating>
    {
        public RatingConfig()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Text)
                .HasMaxLength(200);

            // Table & Column Configpings
            ToTable("Rating", "Rater");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Text).HasColumnName("Text");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.AspectId).HasColumnName("AspectId");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.Ratings)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.RatingAspect)
                .WithMany(t => t.Ratings)
                .HasForeignKey(d => d.AspectId);
        }
    }
}