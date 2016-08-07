using Framework.Core.Data;
using Framework.Core.Data.Core;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response;
using System;
using System.Collections.Generic;

namespace Rater.ReadModel.Repositories
{
    public class FieldReadRepository : BaseReadRepository<RatingFieldReponse>, IFieldReadRepository
    {
        public FieldReadRepository(IReadContext context) : base(context.Set<RatingFieldReponse>())
        {
        }

        public RatingFieldReponse GetFieldById(Guid fieldId)
        {
            return FindSingleBy(f => f.FieldId == fieldId);
        }

        public IEnumerable<RatingFieldReponse> SearchFieldRatings(string searchText, int pageNumber, int pageSize)
        {
            if (string.IsNullOrEmpty(searchText))
                return GetAll(f => f.FieldName, pageNumber, pageSize);
            else
                return FindBy(f => f.FieldName.Contains(searchText), f => f.FieldName, pageNumber, pageSize);
        }
    }
}