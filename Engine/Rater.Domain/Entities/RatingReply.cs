using System;
using Framework.Core.Domain;

namespace Rater.Domain.Entities
{
    public class RatingReply : BaseEntity
    {
        public Guid RatingId { get; set; }
        public string Text { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Rating Rating { get; set; }
    }
}