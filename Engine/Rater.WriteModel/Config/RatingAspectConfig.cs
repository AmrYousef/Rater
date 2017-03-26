//using Rater.Domain.Entities;
//using System.Data.Entity.ModelConfiguration;

//namespace Rater.WriteModel.Config
//{
//    public class RatingAspectConfig : EntityTypeConfiguration<RatingAspect>
//    {
//        public RatingAspectConfig()
//        {
//            // Primary Key
//            HasKey(t => t.Id);

//            // Properties
//            Property(t => t.Name)
//                .IsRequired()
//                .IsFixedLength()
//                .HasMaxLength(10);

//            // Table & Column Configpings
//            ToTable("RatingAspect", "Rater");
//            Property(t => t.Id).HasColumnName("Id");
//            Property(t => t.Name).HasColumnName("Name");
//            Property(t => t.RatingFieldId).HasColumnName("RatingFieldId");

//            // Relationships
//            HasRequired(t => t.RatingField)
//                .WithMany(t => t.RatingAspects)
//                .HasForeignKey(d => d.RatingFieldId);
//        }
//    }
//}