using Antlr.Runtime;
using System.Reflection.Emit;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QRSCS
{
    public class BundleConfig
    {

    public static void RegisterBundles(BundleCollection bundles)
        {
    bundles.Add(new StyleBundle("~/bundles/css").Include(

    "~/Content/adminassets/assets/css/assets.css",
    "~/Content/adminassets/assets/css/typography.css",
    "~/Content/adminassets/assets/css/shortcodes/shortcodes.css",
    "~/Content/assetstable/css/sb-admin-2.min.css",
    "~/Content/assetstable/vendor/fontawesome-free/css/all.min.css",
     "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.css",
     "~/Content/adminassets/assets/css/style.css",
     "~/Content/adminassets/scrollbar.css",
     "~/Content/adminassets/assets/css/dashboard.css",
    "~/Content/adminassets/assets/css/color/color-1.css",
    "~/Content/adminassets/css/style.css" ,
    "~/Content/adminassets/css/style.css" ,
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/resultstyle.css",
    "~/Content/adminassets/assets/vendors/fontawesome/css/font-awesome.min.css",
    "~/Content/adminassets/resultstyle.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/adminassets/resultstyle.css",
    "~/Content/adminassets/css/style.css",
    "~/Content/IDDcss/IDD.css"





                ));


            // javascript files
    bundles.Add(new StyleBundle("~/bundles/js").Include(
   "~/Content/adminassets/assets/vendors/JotForm/jquery.min.js" ,
   "~/Content/adminassets/assets/js/jquery.min.js" ,
   "~/Content/adminassets/assets/vendors/owl-carousel/owl.carousel.js",
   "~/Content/adminassets/assets/js/admin.js" ,
   "~/Content/adminassets/assets/vendors/counter/counterup.min.js" ,
   "~/Content/adminassets/assets/js/functions.js" ,
   "~/Content/adminassets/assets/vendors/bootstrap/js/bootstrap.min.js" ,
  "~/Content/adminassets/assets/vendors/chart/chart.min.js",
  "~/Content/adminassets/assets/js/jquery.min.js" ,
 "~/Content/JavaScript/CreateUser.js",
  "~/Content/adminassets/assets/js/jquery.min.js" ,
   "~/Content/JavaScript/UpdateTeacher.js" ,
  "~/Content/adminassets/assets/js/jquery.min.js" ,
 "~/Content/JavaScript/UpdateUser.js" ,
 "~/Content/assetstable/vendor/jquery/jquery.min.js",
 "~/Content/assetstable/vendor/bootstrap/bootstrap.bundle.min.js",
 "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js",
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js",
 "~/Content/assetstable/js/datatables-demo.js",
  "~/Content/assetstable/js/datatables-demo.js" ,
 "~/Content/JavaScript/ViewAllUser.js" ,
  "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js" ,
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js",
 "~/Content/assetstable/vendor/jquery/jquery.min.js" ,
  "~/Content/JavaScript/AudiologyAssessment.js" ,
   "~/Content/JavaScript/CaseHistory.js",
   "~/Content/adminassets/assets/vendors/JotForm/prototypeform.js" ,
 "~/Content/adminassets/assets/vendors/JotForm/jotforms.js" ,
 "~/Content/adminassets/js/vendor/maskedinput.min.js?v=3.3.27613" ,
 "~/Content/adminassets/js/vendor/jquery.maskedinput.min.js?v=3.3.27613" ,
 "~/Content/JavaScript/NewAdmission.js" ,
 "~/Content/JavaScript/Performance.js",
  "~/Content/adminassets/assets/vendors/JotForm/prototypeform.js" ,
 "~/Content/adminassets/assets/vendors/JotForm/jotforms.js",
  "~/Content/adminassets/js/vendor/maskedinput.min.js?v=3.3.27613" ,
 "~/Content/adminassets/js/vendor/jquery.maskedinput.min.js?v=3.3.27613" ,
 "~/Content/JavaScript/SpeechCaseHistory.js" ,
 "~/Content/adminassets/assets/js/jquery.min.js" ,
    "~/Content/JavaScript/SpeechTherapyAssessment.js" ,
      "~/Content/JavaScript/BT.js" ,
    "~/Content/JavaScript/IEP.js",
     "~/Scripts/jquery-3.6.0.js" ,
"~/Scripts/jquery-3.6.0.min.js" ,
 "~/Content/JavaScript/IQ.js",
  "~/Scripts/jquery-3.6.0.js" ,
 "~/Scripts/jquery-3.6.0.min.js" ,
 "~/Content/JavaScript/OT.js" ,
 "~/Content/JavaScript/OT2.js" ,
"~/Scripts/jquery-3.6.0.js" ,
 "~/Scripts/jquery-3.6.0.min.js" ,
 "~/Content/JavaScript/PA.js",
 "~/Content/JavaScript/performance1.js" ,
  "~/Scripts/jquery-3.6.0.js" ,
"~/Scripts/jquery-3.6.0.min.js",
"~/Content/JavaScript/PT.js" ,
 "~/Content/JavaScript/UpdateIEP.js" ,
 "~/Content/JavaScript/ViewAllIEP.js" ,
 "~/Content/adminassets/script.js" ,
  "~/Content/JavaScript/HIResult.js" ,
  "~/Content/adminassets/script.js" ,
"~/Content/JavaScript/IDDResult.js" ,
"~/Content/JavaScript/Result.js" ,
 "~/Content/adminassets/script.js" ,
 "~/Content/JavaScript/VIResult.js" ,
 "~/Content/assetstable/js/demo/datatables-demo.js",
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js",
 "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js",
 "~/Content/assetstable/js/sb-admin-2.min.js",
 "~/Content/assetstable/vendor/jquery-easing/jquery.easing.min.js",
 "~/Content/assetstable/vendor/bootstrap/js/bootstrap.bundle.min.js",
 "~/Content/assetstable/vendor/jquery/jquery.min.js",
  "~/Content/adminassets/assets/js/jquery.min.js" ,
   "~/Content/JavaScript/CreateTeacher.js" ,
   "~/Content/assetstable/js/demo/datatables-demo.js",
 "~/Content/JavaScript/AllStudentsView.js" ,
  "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js" ,
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js" ,
  "~/Content/assetstable/js/sb-admin-2.min.js",
 "~/Content/assetstable/vendor/jquery/jquery.min.js",
 "~/Content/assetstable/vendor/bootstrap/js/bootstrap.bundle.min.js" ,
 "~/Content/assetstable/vendor/jquery-easing/jquery.easing.min.js",
 "~/Content/assetstable/vendor/jquery/jquery.min.js",
 "~/Content/assetstable/vendor/bootstrap/js/bootstrap.bundle.min.js" ,
 "~/Content/assetstable/vendor/jquery-easing/jquery.easing.min.js" ,
 "~/Content/assetstable/js/sb-admin-2.min.js" ,
 "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js" ,
"~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js" ,
 "~/Content/assetstable/js/demo/datatables-demo.js" ,
 "~/Content/assetstable/vendor/jquery/jquery.min.js" ,
 "~/Content/assetstable/vendor/bootstrap/js/bootstrap.bundle.min.js",
 "~/Content/assetstable/vendor/jquery-easing/jquery.easing.min.js",
 "~/Content/assetstable/js/sb-admin-2.min.js" ,
 "~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js" ,
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js" ,
 "~/Content/assetstable/js/demo/datatables-demo.js" ,
 "~/Content/adminassets/assets/vendors/JotForm/prototypeform.js",
 "~/Content/adminassets/assets/vendors/JotForm/jotforms.js",
 "~/Content/adminassets/js/vendor/maskedinput.min.js?v=3.3.27613",
 "~/Content/adminassets/js/vendor/jquery.maskedinput.min.js?v=3.3.27613",
  "~/Content/assetstable/vendor/jquery/jquery.min.js" ,
 "~/Content/assetstable/vendor/bootstrap/js/bootstrap.bundle.min.js" ,
 "~/Content/assetstable/vendor/jquery-easing/jquery.easing.min.js" ,
 "~/Content/assetstable/js/sb-admin-2.min.js" ,
"~/Content/assetstable/vendor/datatables/jquery.dataTables.min.js" ,
 "~/Content/assetstable/vendor/datatables/dataTables.bootstrap4.min.js" ,
 "~/Content/assetstable/js/demo/datatables-demo.js" ,
 "~/Content/adminassets/assets/vendors/JotForm/jquery.min.js",
 "~/Content/adminassets/assets/js/admin.js",
   "~/Content/adminassets/assets/vendors/counter/counterup.min.js" ,
  "~/Content/adminassets/assets/vendors/counter/waypoints-min.js" ,
   "~/Content/adminassets/assets/js/functions.js" ,
   "~/Content/adminassets/assets/vendors/bootstrap/js/bootstrap.min.js",
   "~/Content/adminassets/assets/vendors/chart/chart.min.js",
   "~/Content/assetstable/Printtable.js",
   "~/Scripts/jquery-3.4.1.min.js",
   "~/Scripts/bootstrap.min.js"














     ));
            
        }
    }
}
