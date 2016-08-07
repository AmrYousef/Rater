using Rater.Core.ReadModelData.Response;
using System;

namespace Rater.Services.Http.Models.ApiData.RatingField
{
    public class RatingFieldApiReponse
    {
        public Guid FieldId { get; set; }
        public string FieldName { get; set; }

        public RatingFieldApiReponse(RatingFieldReponse response)
        {
            FieldId = response.FieldId;
            FieldName = response.FieldName;
        }
    }
}