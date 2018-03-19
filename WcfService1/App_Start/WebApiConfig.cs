using Autofac;
using Autofac.Integration.WebApi;
using Business.BusinessClasses;
using Business.Interfaces;
using Repository.Interfaces;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.DependencyResolver = new AutofacWebApiDependencyResolver(WebApiConfig.CreateMappings());
        }

        public static IContainer CreateMappings()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<BoardGames>().As<IBoardGames>().InstancePerRequest();
            builder.RegisterType<Designers>().As<IDesigners>().InstancePerRequest();
            builder.RegisterType<Publishers>().As<IPublishers>().InstancePerRequest();
            builder.RegisterType<Reviewers>().As<IReviewers>().InstancePerRequest();
            builder.RegisterType<BoardGameRepository>().As<IBoardGameRepository>().InstancePerRequest();
            builder.RegisterType<DesignerRepository>().As<IDesignerRepository>().InstancePerRequest();
            builder.RegisterType<PublisherRepository>().As<IPublisherRepository>().InstancePerRequest();
            builder.RegisterType<ReviewerRepository>().As<IReviewerRepository>().InstancePerRequest();

            var container = builder.Build();
            return container;
        }
    }
}
