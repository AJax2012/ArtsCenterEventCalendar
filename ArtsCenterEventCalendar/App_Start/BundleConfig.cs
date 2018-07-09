using System.Web.Optimization;

namespace ArtsCenterEventCalendar
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

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/popper.js",
                      "~/Scripts/bootbox.js",
                      "~/scripts/datatables/jquery.datatables.min.js",
                      "~/scripts/datatables/datatables.bootstrap4.min.js",
                      "~/Scripts/jquery.datetimepicker.full.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-slate.css",
                      "~/Content/site.css",
                      "~/Content/time-icon.css",
                      "~/Content/DataTables/css/dataTables.bootstrap4.css",
                      "~/Content/jquery.datetimepicker.css"));
        }
    }
}
