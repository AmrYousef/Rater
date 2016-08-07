using Framework.Core.CQRS;
using System;

namespace Rater.Core.Contracts.Queries
{
    public class GetFieldById : AuthenticatedQuery
    {
        public GetFieldById(Guid fieldId, Guid userId) :
            base(userId)
        {
            FieldId = fieldId;
        }

        public Guid FieldId { get; set; }
    }
}