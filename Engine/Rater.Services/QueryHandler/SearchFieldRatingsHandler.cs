using Framework.Core.CQRS;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response;
using Rater.Core.ReadModelData.Response.Collection;

namespace Rater.Services.QueryHandler
{
    public class SearchFieldRatingsHandler : BaseQueryHandler<SearchFieldRatings, RatingFieldReponseCollection>
    {
        private readonly IFieldReadRepository _fieldReadRepository;

        public SearchFieldRatingsHandler(IFieldReadRepository fieldReadRepository)
        {
            _fieldReadRepository = fieldReadRepository;
        }

        public override RatingFieldReponseCollection Handle(SearchFieldRatings query)
        {
            return new RatingFieldReponseCollection(_fieldReadRepository.SearchFieldRatings(query.SearchText, query.PageNumber, query.PageSize));
        }
    }
}