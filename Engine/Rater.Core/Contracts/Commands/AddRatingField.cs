using Framework.Core.CQRS;
using Framework.Core.Securtiy;

namespace Rater.Core.Contracts.Commands
{
    public class AddRatingField : Command
    {
        public string FieldName { get; private set; }

        public AddRatingField(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}