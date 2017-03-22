using System;
using Framework.Core.CQRS;
using Framework.Core.Securtiy;

namespace Rater.Core.Contracts.Commands
{
    public class DeleteRatingField : AuthenticatedCommand
    {
        public DeleteRatingField(Guid fieldId, FrameworkClaimsIdentity identity) : base(identity)
        {
            FieldId = fieldId;
        }

        public Guid FieldId { get; private set; }
    }
}