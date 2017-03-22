using System.Collections.Generic;
using Framework.Core.CQRS;

namespace Rater.Core.ReadModelData.Response.Collection
{
    public class RatingFieldReponseCollection : BaseQueryReponse
    {
        public RatingFieldReponseCollection(IEnumerable<RatingFieldReponse> ratingFields)
        {
            RatingFields = ratingFields;
        }

        public IEnumerable<RatingFieldReponse> RatingFields { get; set; }
    }
}