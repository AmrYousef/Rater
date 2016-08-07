using Framework.Core.CQRS;
using Framework.Core.Securtiy;
using System;

namespace Rater.Core.Contracts.Commands
{
    public class DeleteRatingField : AuthenticatedCommand
    {
        public Guid FieldId { get; private set; }

        public DeleteRatingField(Guid fieldId, FrameworkClaimsIdentity identity) : base(identity)
        {
            FieldId = fieldId;
        }
    }
}