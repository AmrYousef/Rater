using Framework.Core.CQRS;
using Framework.Core.Securtiy;

namespace Rater.Core.Contracts.Commands
{
    public class AddRatingField : AuthenticatedCommand
    {
        public string FieldName { get; private set; }

        public AddRatingField(string fieldName, FrameworkClaimsIdentity identity) : base(identity)
        {
            FieldName = fieldName;
        }
    }
}