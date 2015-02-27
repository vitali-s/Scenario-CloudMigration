using System.Web.Optimization;

namespace CloudApplicationNet.Presentation.Configuration
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/javascript/libs").Include(
                      "~/javascript/angular.min.js",
                      "~/javascript/angular-resource.min.js",
                      "~/javascript/angular-route.min.js",
                      "~/javascript/cloud-application.js",
                      "~/javascript/content-controller.js"));

            bundles.Add(new StyleBundle("~/styles/css").Include(
                      "~/styles/bootstrap.css",
                      "~/styles/bootstrap-theme.css",
                      "~/styles/site.css"));
        }
    }
}
