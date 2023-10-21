using MVCAssignment.Factories;
using Libraries.Services.Search;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Libraries.Data;
using System.Data.Entity;

namespace MVCAssignment
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ISearchModelFactory, SearchModelFactory>();
            container.RegisterType<ISearchService, SearchService>();
            container.RegisterType<DbContext, ApplicationContext>();

        }
    }
}