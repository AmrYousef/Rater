using Framework.Core.CQRS;

namespace Rater.Core.Contracts.Commands
{
    public class AddRatingField : Command
    {
        public AddRatingField(string fieldName)
        {
            FieldName = fieldName;
        }

        public string FieldName { get; private set; }
    }
}