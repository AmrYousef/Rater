using Framework.Core.CQRS;
using Framework.Core.Securtiy;
using System;

namespace Rater.Core.Contracts.Commands
{
    public class UpdateRatingField : AuthenticatedCommand
    {
        public string FieldName { get; private set; }
        public Guid FieldId { get; private set; }

        public UpdateRatingField(Guid fieldId, string fieldName, FrameworkClaimsIdentity identity) : base(identity)
        {
            FieldId = fieldId;
            FieldName = fieldName;
        }
    }
}