//using Rater.Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;

//namespace Rater.WriteModel.Config
//{
//    public class CountryConfig //: EntityTypeConfiguration<Country>
//    {
//        public static void Configure(EntityTypeBuilder<Country> builder)
//        {
//            // Primary Key
//            builder.HasKey(t => t.Id);

//            // Properties
//            builder.Property(t => t.Name)
//                .IsRequired()
//                .HasMaxLength(100);

//            // Table & Column Configpings
//            builder.ToTable("Country", "Common");
//            builder.Property(t => t.Id).HasColumnName("Id");
//            builder.Property(t => t.Name).HasColumnName("Name");

//            // Relationships
//            //Many to many is not yet supported in EF Core
//            //builder.HasMany(t => t.RatingattributeCategoryValues)
//            //    .WithMany(t => t.Countries)
//            //    .Map(m =>
//            //        {
//            //            m.MapLeftKey("CountryId");
//            //            m.MapRightKey("RatingAttributeCategoryValueId");
//            //            m.ToTable("RatingAttributeCategoryValueCountry", "Rater");
//            //        });
//        }
//    }
//}