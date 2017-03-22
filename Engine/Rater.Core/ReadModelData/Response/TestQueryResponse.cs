using Framework.Core.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rater.Core.ReadModelData.Response
{
    public class TestQueryResponse : BaseQueryReponse
    {
        public TestQueryResponse(string result)
        {
            Result = result;
        }
        public string Result { get; set; }
    }
}
