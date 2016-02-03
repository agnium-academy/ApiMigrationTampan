using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StudentsAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
<<<<<<< HEAD
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Remove the XML formatter
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
            
=======

            // Remove the XML formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);

>>>>>>> e46b4a0e1d8c5c5e503e1e330befe9dc10c716aa

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
