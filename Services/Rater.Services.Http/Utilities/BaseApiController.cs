using Framework.Core.Securtiy;
using System;
using System.Web.Http;

namespace Rater.Services.Http.Utilities
{
    public class BaseApiController : ApiController
    {
        public FrameworkClaimsIdentity CurrentFrameworkIdentity
        {
            get
            {
                return new FrameworkClaimsIdentity(Guid.Empty);
            }
        }
    }
}