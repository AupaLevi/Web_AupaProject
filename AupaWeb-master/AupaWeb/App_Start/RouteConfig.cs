﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AupaWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Post",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Post", action = "AddNewPost", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "User",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "SignIn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "UserInfo",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Introduce",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "About", action = "AupaIntroduce", id = UrlParameter.Optional }
          );
        }
    }
}
