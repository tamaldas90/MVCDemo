﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;

namespace UsingEFMVCwebAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "GetReviewComments",
                routeTemplate: "api/reviews/comments/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "Reviews", action = "Comments" }
            );

            routes.MapHttpRoute(
                name: "GetByCategories",
                routeTemplate: "api/reviews/categories/{category}",
                defaults: new { category = RouteParameter.Optional, controller = "Reviews", action = "GetByCategory" }
            );

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}