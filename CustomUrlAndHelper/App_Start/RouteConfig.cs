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
                name: "userList",
                url: "{lang}/user/Index",
                defaults: new { controller = "User", action = "Index", lang="en" }
            );
            routes.MapRoute(
                name: "UserCreate",
                url: "{lang}/user/Create",
                defaults: new { controller = "User", action = "Create", lang = "en" }
            );
            routes.MapRoute(
                name: "UserEdit",
                url: "{lang}/user/edit/{id}",
                defaults: new { controller = "User", action = "Edit", id = UrlParameter.Optional, lang = "en" }
            );
            routes.MapRoute(
               name: "UserDelete",
               url: "{lang}/user/delete/{id}",
               defaults: new { controller = "User", action = "Delete", id = UrlParameter.Optional, lang = "en" }
           );
            routes.MapRoute(
               name: "UserDetails",
               url: "{lang}/user/details/{id}",
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
