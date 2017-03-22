using System;
using Framework.Core.Domain;

namespace Rater.Domain.Entities
{
    public class RatingAttribute : BaseEntity
    {
        public Guid? RatingAttributeCategoryValue { get; set; }
        public Guid RatingId { get; set; }
        public string FreeTextRatingCategoryValue { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual RatingattributeCategoryValue RatingattributeCategoryValue1 { get; set; }
    }
}