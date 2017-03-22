using Framework.Core.CQRS;
using Framework.Core.Data.Core;
using Rater.Core.Contracts.Commands;
using Rater.Domain.Entities;
using Rater.Domain.Repository;

namespace Rater.Services.CommandHandler
{
    public class AddRatingFieldHandler : BaseCommandHandler<AddRatingField>
    {
        private IUnitOfWork _unitOfWork;

        public AddRatingFieldHandler()//IUnitOfWork unitOfWork)
        {
            //_unitOfWork = unitOfWork;
        }

        public override void Handle(AddRatingField command)
        {
            //RatingField newField = RatingField.CreateNew(command.FieldName);

            //_unitOfWork.Repository<IRatingFieldWriteRepository, RatingField>().Add(newField);

            //_unitOfWork.SaveChanges();
        }
    }
}