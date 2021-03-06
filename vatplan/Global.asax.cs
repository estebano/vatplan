﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using vatplan.DB;

namespace vatplan
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            this.BeginRequest += MvcApplication_BeginRequest;
            this.EndRequest += MvcApplication_EndRequest;
        }

        private void MvcApplication_EndRequest(object sender, EventArgs e)
        {
            var efContext = HttpContext.Current.Items["x"] as VatplanEntities;
            efContext?.Dispose();
        }

        private void MvcApplication_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Items["x"] = new VatplanEntities();
        }
    }
}
