using Framework.Core.Domain;
using System;
using System.Collections.Generic;

namespace Rater.Domain.Entities
{
    public class RatingAspect : BaseEntity
    {
        public RatingAspect()
        {
            Ratings = new List<Rating>();
        }

        public string Name { get; set; }
        public Guid RatingFieldId { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual RatingField RatingField { get; set; }
    }
}