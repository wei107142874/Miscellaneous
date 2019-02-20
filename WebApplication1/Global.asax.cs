using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using System.Reflection;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {           
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //PropertiesAutowired自动属性注入(public)
            //例如: Default下的public IUserService userService{get;set;}
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).
                PropertiesAutowired();

            //获取相关类库的程序集
            Assembly[] assemblies = new Assembly[] { Assembly.Load("Service") };
            builder.RegisterAssemblyTypes(assemblies)
                .Where(b => !b.IsAbstract)
                .AsImplementedInterfaces().PropertiesAutowired();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
