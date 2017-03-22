using System;
using Framework.Core.CQRS;
using Framework.Core.Securtiy;

namespace Rater.Core.Contracts.Commands
{
    public class UpdateRatingField : AuthenticatedCommand
    {
        public UpdateRatingField(Guid fieldId, string fieldName, FrameworkClaimsIdentity identity) : base(identity)
        {
            FieldId = fieldId;
            FieldName = fieldName;
        }

        public string FieldName { get; private set; }
        public Guid FieldId { get; private set; }
    }
}