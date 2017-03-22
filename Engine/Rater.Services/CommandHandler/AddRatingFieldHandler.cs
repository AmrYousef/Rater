using Framework.Core.CQRS;
using Framework.Core.Data.Core;
using Rater.Core.Contracts.Commands;

namespace Rater.Services.CommandHandler
{
    public class AddRatingFieldHandler : BaseCommandHandler<AddRatingField>
    {
        private IUnitOfWork _unitOfWork;

        public override void Handle(AddRatingField command)
        {
            //RatingField newField = RatingField.CreateNew(command.FieldName);

            //_unitOfWork.Repository<IRatingFieldWriteRepository, RatingField>().Add(newField);

            //_unitOfWork.SaveChanges();
        }
    }
}