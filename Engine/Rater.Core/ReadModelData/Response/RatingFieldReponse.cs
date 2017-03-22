using System;
using Framework.Core.CQRS;

namespace Rater.Core.ReadModelData.Response
{
    public class RatingFieldReponse : BaseQueryReponse
    {
        public Guid FieldId { get; set; }
        public string FieldName { get; set; }
    }
}