using Framework.Core.CQRS;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response;

namespace Rater.Services.QueryHandler
{
    public class SearchFieldRatingsHandler : BaseQueryHandler<SearchFieldRatings, TestQueryResponse>
        // RatingFieldReponseCollection>
    {
        private IFieldReadRepository _fieldReadRepository;

        public override TestQueryResponse Handle(SearchFieldRatings query)
        {
            return new TestQueryResponse("Result");
            //return new RatingFieldReponseCollection(_fieldReadRepository.SearchFieldRatings(command.SearchText, command.PageNumber, command.PageSize));
        }
    }
}