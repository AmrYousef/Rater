using Framework.Core.CQRS.Core;
using Framework.Core.Data.Core;
using Framework.CQRS;
using Framework.LightInject;
using Framework.LightInject.WebApi.LightInject;
using Rater.Core.Contracts.Commands;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Core.ReadModelData.Response;
using Rater.Core.ReadModelData.Response.Collection;
using Rater.Domain.Repository;
using Rater.ReadModel;
using Rater.ReadModel.Repositories;
using Rater.Services.CommandHandler;
using Rater.Services.QueryHandler;
using Rater.WriteModel;
using Rater.WriteModel.Repositories;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Rater.Services.Http
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new LightInjectContainer();
            container.Register<ICommandBus, SimpleCommandBus>();
            container.Register<IQueryBus, SimpleQueryBus>();
            container.Register<IReadContext, RaterReadContext>();
            container.Register<IFieldReadRepository, FieldReadRepository>();
            container.RegisterQueryHandler<GetFieldById, GetFieldByIdHandler, RatingFieldReponse>();
            container.RegisterQueryHandler<SearchFieldRatings, SearchFieldRatingsHandler, RatingFieldReponseCollection>();

            container.Register<IWriteContext, RaterWriteContext>();
            container.Register<IUnitOfWork, RaterUnitOfwork>();
            container.Register<IRatingFieldWriteRepository, RatingFieldWriteRepository>();
            container.RegisterCommandHandler<AddRatingField, AddRatingFieldHandler>();
            container.RegisterCommandHandler<UpdateRatingField, UpdateRatingFieldHandler>();
            container.RegisterCommandHandler<DeleteRatingField, DeleteRatingFieldHandler>();

            container.RegisterApiControllers();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}