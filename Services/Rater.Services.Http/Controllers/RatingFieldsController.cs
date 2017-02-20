using Framework.Core.CQRS.Core;
using Rater.Core.Contracts.Commands;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Response;
using Rater.Core.ReadModelData.Response.Collection;
using Rater.Services.Http.Models.ApiData.RatingField;
using Rater.Services.Http.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Rater.Services.Http.Controllers
{
    public class RatingFieldsController : BaseApiController
    {
        private ICommandBus _commandBus;
        private IQueryBus _queryBus;

        public RatingFieldsController(ICommandBus commandBus, IQueryBus queryBus)
        {
            _commandBus = commandBus;
            _queryBus = queryBus;
        }

        // GET api/values
        public IEnumerable<RatingFieldApiReponse> Get(int pageNumber = 1, int pageSize = 10)
        {
            var query = new SearchFieldRatings(pageNumber, pageSize);
            var result = _queryBus.Send<SearchFieldRatings, RatingFieldReponseCollection>(query);

            return result.RatingFields.Select(r => new RatingFieldApiReponse(r));
        }

        public IEnumerable<RatingFieldApiReponse> Get(string searchText, int pageNumber = 1, int pageSize = 10)
        {
            var query = new SearchFieldRatings(searchText, pageNumber, pageSize);
            var result = _queryBus.Send<SearchFieldRatings, RatingFieldReponseCollection>(query);

            return result.RatingFields.Select(r => new RatingFieldApiReponse(r));
        }

        // GET api/values/5
        public RatingFieldApiReponse Get(Guid id)
        {
            var query = new GetFieldById(id, CurrentFrameworkIdentity);
            var result = _queryBus.Send<GetFieldById, RatingFieldReponse>(query);

            if (result != null)
                return new RatingFieldApiReponse(result);
            else
                return null;
        }

        // POST api/values
        public void Post([FromBody]CreateFieldData data)
        {
            var command = new AddRatingField(data.FieldName, CurrentFrameworkIdentity);
            _commandBus.Send(command);
        }

        // PUT api/values/5
        public void Put(Guid id, [FromBody]UpdateFieldData data)
        {
            var command = new UpdateRatingField(id, data.FieldName, CurrentFrameworkIdentity);
            _commandBus.Send(command);
        }

        // DELETE api/values/5
        public void Delete(Guid id)
        {
            var command = new DeleteRatingField(id, CurrentFrameworkIdentity);
            _commandBus.Send(command);
        }
    }
}