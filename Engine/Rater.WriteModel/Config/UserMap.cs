//using Rater.Domain.Entities;
//using System.Data.Entity.ModelConfiguration;

//namespace Rater.WriteModel.Config
//{
//    public class UserConfig : EntityTypeConfiguration<User>
//    {
//        public UserConfig()
//        {
//            // Primary Key
//            HasKey(t => t.Id);

//            // Properties
//            Property(t => t.Email)
//                .IsRequired()
//                .HasMaxLength(200);

//            Property(t => t.Name)
//                .HasMaxLength(200);

//            // Table & Column Configpings
//            ToTable("User", "Common");
//            Property(t => t.Id).HasColumnName("Id");
//            Property(t => t.Email).HasColumnName("Email");
//            Property(t => t.Name).HasColumnName("Name");
//            Property(t => t.CountryOfPereference).HasColumnName("CountryOfPereference");

//            // Relationships
//            HasRequired(t => t.Country)
//                .WithMany(t => t.Users)
//                .HasForeignKey(d => d.CountryOfPereference);
//        }
//    }
//}