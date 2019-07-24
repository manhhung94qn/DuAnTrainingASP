 using System.Web;
using System.Web.Optimization;

namespace GasStationProject
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/site.css").IncludeDirectory("~/Content/css/", "*.css"));


            //bundles.Add(new Bundle("~/content/image").IncludeDirectory("~/Content/image/", "*.png"));
            bundles.Add(new StyleBundle("~/content/Login").Include("~/Content/css/login.css"));

            bundles.Add(new ScriptBundle("~/content/HomeControler").Include("~/Content/js/HomeController.js"));
            bundles.Add(new StyleBundle("~/content/HomeCSS").Include("~/Content/css/HomeStyle.css"));
            bundles.Add(new ScriptBundle("~/content/addGastation").Include("~/Content/js/jquery.validate.min.js", "~/Content/js/jquery.validate.unobtrusive.min.js", "~/Content/js/GasStationAdd.js"));
            bundles.Add(new ScriptBundle("~/content/Feedback").Include("~/Content/js/FeedbackController.js"));
            bundles.Add(new ScriptBundle("~/content/MapList").Include("~/Content/js/MapList.js"));



            bundles.Add(new ScriptBundle("~/content/CoreScript").Include(
                "~/Content/vendor/bootstrap-4.1/popper.min.js",
                "~/Content/vendor/bootstrap-4.1/bootstrap.min.js",
                "~/Content/vendor/slick/slick.min.js",
                "~/Content/vendor/wow/wow.min.js",
                "~/Content/vendor/animsition/animsition.min.js",
                "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar.min.js",
                "~/Content/vendor/counter-up/jquery.waypoints.min.js",
                "~/Content/vendor/counter-up/jquery.counterup.min.js",
                "~/Content/vendor/circle-progress/circle-progress.min.js",
                "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.js",
                "~/Content/vendor/chartjs/Chart.bundle.min.js",
                "~/Content/vendor/select2/select2.min.js",
                "~/Content/js/main.js",
                "~/Content/js/jquery.inputmask.bundle.js")  );

            bundles.Add(new StyleBundle("~/content/CoreCSS").Include(
                "~/Content/css/font-face.css",
                "~/Content/vendor/font-awesome-4.7/css/font-awesome.min.css",
                "~/Content/vendor/font-awesome-5/css/fontawesome-all.min.css",
                "~/Content/vendor/mdi-font/css/material-design-iconic-font.min.css",
                "~/Content/vendor/bootstrap-4.1/bootstrap.min.css",
                "~/Content/vendor/animsition/animsition.min.css",
                "~/Content/vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css",
                "~/Content/vendor/wow/animate.css",
                "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                "~/Content/vendor/slick/slick.css",
                "~/Content/vendor/select2/select2.min.css",
                "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.css",
                "~/Content/css/theme.css",
                "~/Content/css/waiting_loading.css"
                ));



        }
    }
}