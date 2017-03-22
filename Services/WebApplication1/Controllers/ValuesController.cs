using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Framework.Core.CQRS.Core;
using Rater.Core.Contracts.Commands;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Response;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICommandBus _commandBus;
        private IQueryBus _queryBus;
        public ValuesController(ICommandBus commandBus, IQueryBus queryBus)
        {
            _commandBus = commandBus;
            _queryBus = queryBus;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var command = new AddRatingField("test");
            //_commandBus.Send(command);
            //return new string[] { "Success"}; ;

            var query = new SearchFieldRatings("" , 0 , 0);
            var result = _queryBus.Send<SearchFieldRatings, TestQueryResponse>(query);

            return new string[] { result.Result };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
