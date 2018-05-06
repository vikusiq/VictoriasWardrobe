using System.Web;
using System.Web.Optimization;

namespace VictoriasWardrobe
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include("~/Scripts/jquery-1.11.1.min.js", 
                "~/Scripts/megamenu.js", "~/Scripts/menu_jquery.js", "~/Scripts/simpleCart.min.js",
                "~/Scripts/jquery-ui.min.js", "~/Scripts/jquery.etalage.min.js", "~/Scripts/jquery.jscrollpane.min.js"));
            bundles.Add(new StyleBundle("~/bundles/style").Include("~/Content/bootstrap.css", "~/Content/style.css", "~/Content/megamenu.css", "~/Content/etalage.css"));

        }

    }
}
