using System.Web.Optimization;

namespace Asia
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-{version}.js",
				"~/Scripts/jquery-{version}.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/easyui").Include(
				"~/Scripts/jquery.easyui-{version}.js",
				"~/Scripts/jquery.easyui-{version}.min.js"));

			bundles.Add(new StyleBundle("~/easyui/css").Include(
					  "~/Content/themes/black/easyui.css",
					  "~/Content/themes/icon.css"));
		}
	}
}