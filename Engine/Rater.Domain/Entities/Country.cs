using Framework.Core.Domain;
using System.Collections.Generic;

namespace Rater.Domain.Entities
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Users = new List<User>();
            RatingattributeCategoryValues = new List<RatingattributeCategoryValue>();
        }

        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RatingattributeCategoryValue> RatingattributeCategoryValues { get; set; }
    }
}