using System.Web;
using System.Web.Optimization;

namespace T2008M_WAP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // add css theme
            bundles.Add(new StyleBundle("~/admin/css").Include(
                      "~/Content/admin/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/admin/css/sb-admin-2.min.css",
                      "~/Content/admin/vendor/datatables/dataTables.bootstrap4.min.css"
                ));
            // add js theme
            bundles.Add(new ScriptBundle("~/admin/js").Include(
                        "~/Content/admin/vendor/jquery/jquery.min.js",
                        "~/Content/admin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/admin/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Content/admin/js/sb-admin-2.min.js",
                        "~/Content/admin/vendor/datatables/jquery.dataTables.min.js",
                        "~/Content/admin/vendor/datatables/dataTables.bootstrap4.min.js",
                        "~/Content/admin/js/demo/datatables-demo.js"
                ));
        }
    }
}
