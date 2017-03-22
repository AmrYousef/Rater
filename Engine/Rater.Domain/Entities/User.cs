using System;
using System.Collections.Generic;
using Framework.Core.Domain;

namespace Rater.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Ratings = new List<Rating>();
            RatingReplies = new List<RatingReply>();
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public Guid CountryOfPereference { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<RatingReply> RatingReplies { get; set; }
    }
}