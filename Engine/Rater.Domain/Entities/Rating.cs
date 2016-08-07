using Framework.Core.Domain;
using System;
using System.Collections.Generic;

namespace Rater.Domain.Entities
{
    public class Rating : BaseEntity
    {
        public Rating()
        {
            RatingAttributes = new List<RatingAttribute>();
            RatingReplies = new List<RatingReply>();
        }

        public string Text { get; set; }
        public short Score { get; set; }
        public Guid UserId { get; set; }
        public Guid AspectId { get; set; }
        public virtual User User { get; set; }
        public virtual RatingAspect RatingAspect { get; set; }
        public virtual ICollection<RatingAttribute> RatingAttributes { get; set; }
        public virtual ICollection<RatingReply> RatingReplies { get; set; }
    }
}