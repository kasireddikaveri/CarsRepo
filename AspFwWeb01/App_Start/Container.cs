using Autofac.Integration.Mvc;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Repository.Implementations;
using DataLayer.Repository.Interfaces;
using DataLayerProject.Repository.Implementations;
using DataLayerProject.Repository.Interfaces;
using DataLayerProject;

namespace AspFwWeb01.App_Start
{
    public class Container
    {
        internal static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<CarsDBContext>();

            //CONFIG SETTING
            builder.RegisterType<GetCarsRepository>()
                .As<IGetCarsRepository>();


            builder.RegisterType<GetCarByIdRepository>()
                .As<IGetCarByIdRepository>();

            builder.RegisterType<AddNewCarRepository>().As<IAddNewCarRepository>();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}