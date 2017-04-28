using Autofac;
using Autofac.Integration.Mvc;
using bys.training.database;
using bys.training.teamWings.sqlDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace bys.training.teamWings.Fac
{
    public class FacHelper
    {
        public static void CreateFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register implement
            
            builder.RegisterType<WingsDal>().As<IWingsDal>().InstancePerRequest();

            // Register dependency
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


        }
    }
}