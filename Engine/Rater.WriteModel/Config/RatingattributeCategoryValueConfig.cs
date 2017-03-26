//using Rater.Domain.Entities;
//using System.Data.Entity.ModelConfiguration;

//namespace Rater.WriteModel.Config
//{
//    public class RatingattributeCategoryValueConfig : EntityTypeConfiguration<RatingattributeCategoryValue>
//    {
//        public RatingattributeCategoryValueConfig()
//        {
//            // Primary Key
//            HasKey(t => t.Id);

//            // Properties
//            Property(t => t.Value)
//                .IsRequired()
//                .HasMaxLength(200);

//            // Table & Column Configpings
//            ToTable("RatingattributeCategoryValue", "Rater");
//            Property(t => t.Id).HasColumnName("Id");
//            Property(t => t.Value).HasColumnName("Value");
//            Property(t => t.RatingattributeCategoryId).HasColumnName("RatingattributeCategoryId");

//            // Relationships
//            HasOptional(t => t.RatingattributeCategory)
//                .WithMany(t => t.RatingattributeCategoryValues)
//                .HasForeignKey(d => d.RatingattributeCategoryId);
//        }
//    }
//}