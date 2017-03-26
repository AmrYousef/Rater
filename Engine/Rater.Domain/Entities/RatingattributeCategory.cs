//using System;
//using System.Collections.Generic;
//using Framework.Core.Domain;

//namespace Rater.Domain.Entities
//{
//    public class RatingattributeCategory : BaseEntity
//    {
//        public RatingattributeCategory()
//        {
//            RatingattributeCategoryValues = new List<RatingattributeCategoryValue>();
//        }

//        public string Name { get; set; }
//        public Guid? RatingFieldId { get; set; }
//        public virtual ICollection<RatingattributeCategoryValue> RatingattributeCategoryValues { get; set; }
//        public virtual RatingField RatingField { get; set; }
//    }
//}