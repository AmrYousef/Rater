using Framework.Core.CQRS.Core;
using Framework.CQRS;
using Framework.SimpleInjector;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Rater.Core.Contracts.Commands;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Response;
using Rater.Services.CommandHandler;
using Rater.Services.QueryHandler;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            //services.add

            var container = new FrameworkDependencyContainer();
            container.Register<ICommandBus, SimpleCommandBus>();
            container.Register<IQueryBus, SimpleQueryBus>();
            //container.Register<IReadContext, RaterReadContext>();
            //container.Register<IFieldReadRepository, FieldReadRepository>();
            //container.RegisterQueryHandler<GetFieldById, GetFieldByIdHandler, RatingFieldReponse>();
            container.RegisterQueryHandler<SearchFieldRatings, SearchFieldRatingsHandler, TestQueryResponse>();


            services.AddSimpleInjectorTagHelperActivation(container);
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(container));
            //container.Register<IWriteContext, RaterWriteContext>();
            //container.Register<IUnitOfWork, RaterUnitOfwork>();
            //container.Register<IRatingFieldWriteRepository, RatingFieldWriteRepository>();
            container.RegisterCommandHandler<AddRatingField, AddRatingFieldHandler>();
            //container.RegisterCommandHandler<UpdateRatingField, UpdateRatingFieldHandler>();
            //container.RegisterCommandHandler<DeleteRatingField, DeleteRatingFieldHandler>();


            //container.Registerapi

            //return container.GetInstance<IServiceProvider>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}