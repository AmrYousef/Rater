using Framework.Core.CQRS;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response.Collection;

namespace Rater.Services.QueryHandler
{
    public class SearchFieldRatingsHandler : BaseQueryHandler<SearchFieldRatings, RatingFieldReponseCollection>
    {
        private IFieldReadRepository _fieldReadRepository;

        public SearchFieldRatingsHandler(IFieldReadRepository fieldReadRepository)
        {
            _fieldReadRepository = fieldReadRepository;
        }

        public override RatingFieldReponseCollection Handle(SearchFieldRatings command)
        {
            return new RatingFieldReponseCollection(_fieldReadRepository.SearchFieldRatings(command.SearchText, command.PageNumber, command.PageSize));
        }
    }
}