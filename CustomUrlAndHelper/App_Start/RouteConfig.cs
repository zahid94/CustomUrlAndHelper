using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomUrlAndHelper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "UserList",
                url: "{lang}/{controller}/index",
                defaults: new { controller = "User", action = "Index", lang="en" }
            );
            routes.MapRoute(
                name: "UserCreate",
                url: "{lang}/{controller}/Create",
                defaults: new { controller = "User", action = "Create", lang = "en" }
            );
            routes.MapRoute(
                name: "UserEdit",
                url: "{lang}/{controller}/Edit/{id}",
                defaults: new { controller = "User", action = "Edit", id = UrlParameter.Optional, lang = "en" }
            );
            routes.MapRoute(
               name: "UserDelete",
               url: "{lang}/{controller}/delete/{id}",
               defaults: new { controller = "User", action = "Delete", id = UrlParameter.Optional, lang = "en" }
           );
            routes.MapRoute(
               name: "UserDetails",
               url: "{lang}/{controller}/details/{id}",
               defaults: new { controller = "User", action = "Details", id = UrlParameter.Optional, lang = "en" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
