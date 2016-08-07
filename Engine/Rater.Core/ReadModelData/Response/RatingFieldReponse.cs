using Framework.Core.CQRS;
using System;

namespace Rater.Core.ReadModelData.Response
{
    public class RatingFieldReponse : BaseQueryReponse
    {
        public Guid FieldId { get; set; }
        public string FieldName { get; set; }
    }
}