using System.Collections.Generic;
using System.Linq;
using Framework.Core.CQRS.Core;
using Microsoft.AspNetCore.Mvc;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Response;
using Rater.Core.ReadModelData.Response.Collection;
using Rater.Core.Contracts.Commands;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public ValuesController(ICommandBus commandBus, IQueryBus queryBus)
        {
            _commandBus = commandBus;
            _queryBus = queryBus;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var command = new AddRatingField("test");
            _commandBus.Send(command);
            return new string[] { "Success" }; ;

            //var query = new SearchFieldRatings("", 1, 10);
            //var result = _queryBus.Send<SearchFieldRatings, RatingFieldReponseCollection>(query);

            //return result.RatingFields.Select(x => x.FieldName).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}