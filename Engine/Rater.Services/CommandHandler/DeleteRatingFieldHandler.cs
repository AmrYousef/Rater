using Framework.Core.CQRS;
using Framework.Core.Data.Core;
using Rater.Core.Contracts.Commands;
using Rater.Domain.Entities;
using Rater.Domain.Repository;

namespace Rater.Services.CommandHandler
{
    public class DeleteRatingFieldHandler : BaseCommandHandler<DeleteRatingField>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRatingFieldHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override void Handle(DeleteRatingField command)
        {
            var fieldFepository = _unitOfWork.Repository<IRatingFieldWriteRepository, RatingField>();
            var deletedField = fieldFepository.GetFieldById(command.FieldId);

            deletedField.Delete();

            fieldFepository.Delete(deletedField);

            _unitOfWork.SaveChanges();
        }
    }
}