using Framework.Core.Data.Core;
using Rater.Core.ReadModelData.Response;
using System;
using System.Collections.Generic;

namespace Rater.Core.ReadModelData.Repositories
{
    public interface IFieldReadRepository : IRepository<RatingFieldReponse>
    {
        RatingFieldReponse GetFieldById(Guid fieldId);

        IEnumerable<RatingFieldReponse> SearchFieldRatings(string searchText, int pageNumber, int pageSize);
    }
}