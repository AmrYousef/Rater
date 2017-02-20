using Framework.Core.CQRS;
using Framework.Core.Securtiy;
using System;

namespace Rater.Core.Contracts.Queries
{
    public class GetFieldById : AuthenticatedQuery
    {
        public GetFieldById(Guid fieldId , FrameworkClaimsIdentity identity) :
            base(identity)
        {
            FieldId = fieldId;
        }

        public Guid FieldId { get; set; }
    }
}