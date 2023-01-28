using System.Web.Optimization;

namespace Heuristics.TechEval.Web {
	public class BundleConfig {
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles) {
			bundles.Add(new Bundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new Bundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			bundles.Add(new Bundle("~/bundles/jquery.form").Include(
						"~/Scripts/jquery.form.min.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new Bundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new Bundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));
		}
	}
}
