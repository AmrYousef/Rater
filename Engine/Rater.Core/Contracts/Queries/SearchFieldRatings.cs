using Framework.Core.CQRS;

namespace Rater.Core.Contracts.Queries
{
    public class SearchFieldRatings : Query
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }

        public SearchFieldRatings(string searchText, int pageNumber, int pageSize)
        {
            SearchText = searchText;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public SearchFieldRatings(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}