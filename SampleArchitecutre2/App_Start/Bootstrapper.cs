using Autofac;
using Autofac.Integration.Mvc;
using DAL.Infrastructure;
using DAL.RepositoryImplementions;
using SampleArchitecutre2.mail;
using SampleArchitecutre2.Mapping;
using Service.RepositoryAbstraction;
using Service.ServiceAbstraction;
using Service.ServiceImplemention;
//using Store.Data.Infrastructure;
//using Store.Data.Repositories;
//using Store.Service;
//using Store.Web.Mappings;
//using System;
//using System.Collections.Generic;
using System.Linq;
using System.Reflection;
//using System.Web;
using System.Web.Mvc;

namespace SampleArchitecutre2.App_Start
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
            //Configure AutoMapper
            //AutoMapperConfiguration.Configure();
            Mappings.config();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<MailSender>().As<IEmailService>().InstancePerRequest();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerRequest();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();

            // Repositories
            //builder.RegisterAssemblyTypes(typeof(GadgetRepository).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces().InstancePerRequest();
            //// Services
            //builder.RegisterAssemblyTypes(typeof(GadgetService).Assembly)
            //   .Where(t => t.Name.EndsWith("Service"))
            //   .AsImplementedInterfaces().InstancePerRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}