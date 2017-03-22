using Framework.Core.CQRS;
using Framework.Core.Data.Core;
using Rater.Core.Contracts.Commands;
using Rater.Domain.Entities;
using Rater.Domain.Repository;

namespace Rater.Services.CommandHandler
{
    public class UpdateRatingFieldHandler : BaseCommandHandler<UpdateRatingField>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRatingFieldHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override void Handle(UpdateRatingField command)
        {
            var fieldFepository = _unitOfWork.Repository<IRatingFieldWriteRepository, RatingField>();
            var updatedField = fieldFepository.GetFieldById(command.FieldId);

            updatedField.Update(command.FieldName);

            fieldFepository.Update(updatedField);

            _unitOfWork.SaveChanges();
        }
    }
}