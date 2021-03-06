﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BellWether.Models;

namespace BellWether {
  // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
  // visit http://go.microsoft.com/?LinkId=9394801

  public class MvcApplication : System.Web.HttpApplication {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }

    public static void RegisterRoutes(RouteCollection routes) {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        routes.IgnoreRoute("svc/{resources}.svc/{*pathInfo}");

      routes.MapRoute(
          "Admin", // Route name
          "Admin/", // URL with parameters
          new { area = "Admin", controller = "Home", action = "Index", id = UrlParameter.Optional },
          new[] { "BellWether.Areas.Admin.Controllers" }// Parameter defaults
      );
     
      routes.MapRoute(
          "Default", // Route name
          "{controller}/{action}/{id}", // URL with parameters
          new { controller = "Home", action = "Index", id = UrlParameter.Optional },
          new[] { "BellWether.Controllers" }// Parameter defaults
      );




    }

    protected void Application_Start() {
      AreaRegistration.RegisterAllAreas();

      RegisterGlobalFilters(GlobalFilters.Filters);
      RegisterRoutes(RouteTable.Routes);
      Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
      Database.SetInitializer(new 	DropCreateDatabaseIfModelChanges<BellwetherContext>());
     


    }
  }
}