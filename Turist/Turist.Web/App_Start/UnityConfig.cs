using System.Configuration;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Turist.Repository;
using Turist.Repository.Interfaces;
using Unity.Mvc5;

namespace Turist.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            string connectionString = ConfigurationManager.ConnectionStrings["turistEntities"].ConnectionString;
            container.RegisterType<ITuristRepository, TuristRepository>(new InjectionConstructor(connectionString));
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}