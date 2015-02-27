using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace CloudApplicationNet.Presentation.Configuration
{
    public class DependencyInjectionConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies()
                    .Where(type => type.Namespace.StartsWith("CloudApplicationNet", true, CultureInfo.InvariantCulture)),
                WithMappings.FromMatchingInterface,
                WithName.Default);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
