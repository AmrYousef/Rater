using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Framework.Core.CQRS.Core;
using Framework.CQRS;
using Rater.Core.Contracts.Queries;
using Rater.Services.QueryHandler;
using Rater.Core.ReadModelData.Response;
using SimpleInjector;
using Microsoft.AspNetCore.Mvc.Controllers;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Rater.Core.Contracts.Commands;
using Rater.Services.CommandHandler;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
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
