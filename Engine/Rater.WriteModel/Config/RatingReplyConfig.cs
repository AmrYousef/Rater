//using Rater.Domain.Entities;
//using System.Data.Entity.ModelConfiguration;

//namespace Rater.WriteModel.Config
//{
//    public class RatingReplyConfig : EntityTypeConfiguration<RatingReply>
//    {
//        public RatingReplyConfig()
//        {
//            // Primary Key
//            HasKey(t => t.Id);

//            // Properties
//            Property(t => t.Text)
//                .HasMaxLength(200);

//            // Table & Column Configpings
//            ToTable("RatingReply", "Rater");
//            Property(t => t.Id).HasColumnName("Id");
//            Property(t => t.RatingId).HasColumnName("RatingId");
//            Property(t => t.Text).HasColumnName("Text");
//            Property(t => t.UserId).HasColumnName("UserId");

//            // Relationships
//            HasOptional(t => t.User)
//                .WithMany(t => t.RatingReplies)
//                .HasForeignKey(d => d.UserId);
//            HasRequired(t => t.Rating)
//                .WithMany(t => t.RatingReplies)
//                .HasForeignKey(d => d.RatingId);
//        }
//    }
//}