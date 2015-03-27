﻿using PartiuAcademia.Web.InfraStructure.DependencyResolver;
using PartiuAcademia.Web.InfraStructure.FilterProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PartiuAcademia.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            DependencyResolver.SetResolver(new NinjectDependencyResolver());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            FilterProviders.Providers.Clear();
            FilterProviders.Providers.Add(new FilterProviderCustom());
        }
    }
}
