using Framework.Core.Data;
using Framework.Core.Data.Core;
using Framework.Core.DependencyContainer;

namespace Rater.WriteModel
{
    public class RaterUnitOfwork : BaseUnitOfWork
    {
        public RaterUnitOfwork(IWriteContext context, IDependencyContainer dependencyContainer) : base(context, dependencyContainer)
        {
        }
    }
}