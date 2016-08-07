using Framework.Core.Domain;
using System;
using System.Collections.Generic;

namespace Rater.Domain.Entities
{
    public class RatingattributeCategory : BaseEntity
    {
        public RatingattributeCategory()
        {
            RatingattributeCategoryValues = new List<RatingattributeCategoryValue>();
        }

        public string Name { get; set; }
        public Nullable<Guid> RatingFieldId { get; set; }
        public virtual ICollection<RatingattributeCategoryValue> RatingattributeCategoryValues { get; set; }
        public virtual RatingField RatingField { get; set; }
    }
}