using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using automapper_unity_spike.Models;
using AutoMapper;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;

namespace automapper_unity_spike
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var mapper = AutoMapperConfiguration.AutoMapperInit();

            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IRepo, Repo>();
            container.RegisterInstance<IMapper>(mapper);
            config.DependencyResolver = new UnityResolver(container);

            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
