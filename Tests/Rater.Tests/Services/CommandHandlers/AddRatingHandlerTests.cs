//using Framework.Core.Data.Core;
//using Framework.Core.DependencyContainer;
//using Framework.LightInject;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Rater.Domain.Repository;
//using Rater.Services.CommandHandler;
//using Rater.WriteModel;
//using Rater.WriteModel.Repositories;

//namespace Rater.Tests
//{
//    [TestClass]
//    public class AddRatingHandlerTests
//    {
//        [TestMethod]
//        public void AddRatingHandlerShallAddNewRatingObject()
//        {
//            IDependencyContainer container = new LightInjectContainer();

//            container.RegisterScopeLifetimeObject<IContext, RaterWriteContext>();
//            container.RegisterScopeLifetimeObject<IUnitOfWork, RaterUnitOfwork>();
//            container.Register<IRatingWriteRepository, RatingWriteRepository>();

//            using (container.BeginScope())
//            {
//                IUnitOfWork unitOfWork = container.Resolve<IUnitOfWork>();
//                AddRatingHandler handler = new AddRatingHandler(unitOfWork);
//            }

//        }
//    }
//}