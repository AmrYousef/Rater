using Framework.Core.Data;
using Rater.Domain.Entities;
using Rater.Domain.Repository;
using System;

namespace Rater.WriteModel.Repositories
{
    public class RatingFieldWriteRepository : BaseWriteRepository<RatingField>, IRatingFieldWriteRepository
    {
        public RatingFieldWriteRepository()
        {
        }

        public RatingField GetFieldById(Guid fieldId)
        {
            return GetById(fieldId);
        }
    }
}