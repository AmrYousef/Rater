using Framework.Core.Data.Core;
using Rater.Domain.Entities;
using System;

namespace Rater.Domain.Repository
{
    public interface IRatingFieldWriteRepository : IWriteRepository<RatingField>
    {
        RatingField GetFieldById(Guid fieldId);
    }
}