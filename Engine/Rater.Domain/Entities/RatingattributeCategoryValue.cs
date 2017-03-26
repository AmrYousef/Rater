//using System;
//using System.Collections.Generic;
//using Framework.Core.Domain;

//namespace Rater.Domain.Entities
//{
//    public class RatingattributeCategoryValue : BaseEntity
//    {
//        public RatingattributeCategoryValue()
//        {
//            RatingAttributes = new List<RatingAttribute>();
//            //Countries = new List<Country>();
//        }

//        public string Value { get; set; }
//        public Guid? RatingattributeCategoryId { get; set; }
//        public virtual RatingattributeCategory RatingattributeCategory { get; set; }
//        public virtual ICollection<RatingAttribute> RatingAttributes { get; set; }
//        //public virtual ICollection<Country> Countries { get; set; }
//    }
//}