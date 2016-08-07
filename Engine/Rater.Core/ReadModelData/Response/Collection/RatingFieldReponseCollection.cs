using Framework.Core.CQRS;
using System.Collections.Generic;

namespace Rater.Core.ReadModelData.Response.Collection
{
    public class RatingFieldReponseCollection : BaseQueryReponse
    {
        public IEnumerable<RatingFieldReponse> RatingFields { get; set; }

        public RatingFieldReponseCollection(IEnumerable<RatingFieldReponse> ratingFields)
        {
            RatingFields = ratingFields;
        }
    }
}