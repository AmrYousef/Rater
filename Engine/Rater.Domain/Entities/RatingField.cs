using Framework.Core.Domain;
using System.Collections.Generic;

namespace Rater.Domain.Entities
{
    public class RatingField : BaseEntity
    {
        private RatingField()
        {
            RatingAspects = new List<RatingAspect>();
            RatingattributeCategories = new List<RatingattributeCategory>();
        }

        public string Name { get; set; }
        public virtual ICollection<RatingAspect> RatingAspects { get; set; }
        public virtual ICollection<RatingattributeCategory> RatingattributeCategories { get; set; }

        public static RatingField CreateNew(string fieldName)
        {
            RatingField newField = new RatingField();
            newField.ProcessNew(fieldName);
            return newField;
        }

        public void Delete()
        {
        }

        public void Update(string fieldName)
        {
            Name = fieldName;
        }

        private void ProcessNew(string fieldName)
        {
            Name = fieldName;
        }
    }
}