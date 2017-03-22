using Framework.Core.CQRS;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response;

namespace Rater.Services.QueryHandler
{
    public class GetFieldByIdHandler : BaseQueryHandler<GetFieldById, RatingFieldReponse>
    {
        private readonly IFieldReadRepository _fieldReadRepository;

        public GetFieldByIdHandler(IFieldReadRepository fieldReadRepository)
        {
            _fieldReadRepository = fieldReadRepository;
        }

        public override RatingFieldReponse Handle(GetFieldById command)
        {
            return _fieldReadRepository.GetFieldById(command.FieldId);
        }
    }
}