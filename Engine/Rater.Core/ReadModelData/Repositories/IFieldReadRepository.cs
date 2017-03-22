using System;
using System.Collections.Generic;
using Framework.Core.Data.Core;
using Rater.Core.ReadModelData.Response;

namespace Rater.Core.ReadModelData.Repositories
{
    public interface IFieldReadRepository : IRepository<RatingFieldReponse>
    {
        RatingFieldReponse GetFieldById(Guid fieldId);

        IEnumerable<RatingFieldReponse> SearchFieldRatings(string searchText, int pageNumber, int pageSize);
    }
}