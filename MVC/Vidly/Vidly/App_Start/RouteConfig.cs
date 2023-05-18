using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //custom routeing

            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    name:"MoviesByRelaseDate",
            //    url: "movies/released/{year}/{month}",
            //    new {Controller = "Movies", Action = "ByRelaseDate"},
            //    new {year=@"\d{4}", month=@"\d{2}"}); //how many value to pass

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
