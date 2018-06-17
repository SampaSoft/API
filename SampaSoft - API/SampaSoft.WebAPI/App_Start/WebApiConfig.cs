using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Practices.Unity;
using SampaSoft.ViewModel.DTO;

namespace SampaSoft.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuração e serviços da Web API

            // Rotas da Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
