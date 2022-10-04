using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QRSCS.Models;
using QRSCS.Manager;
using QRSCS.Filters;
using System.IO;

namespace QRSCS_Database
{
    namespace QRSCS.Manager
    {
        
        public class DashboardManager
        {
            private QRSCS_DatabaseEntities db = new QRSCS_DatabaseEntities();
            public DashboardDTOModel Cards(DashboardDTOModel dm)
            {
                dm.DashboardModel.total_users = db.Users.Count();
                dm.DashboardModel.total_teachers = db.Create_Teacher.Count();
                dm.DashboardModel.total_students = db.New_Admission.Count();
                dm.DashboardModel.total_IEP = db.IEPlans.Count();

                var hi = db.New_Admission.Where(x => x.Disability == "H.I").Count();
                var vi = db.New_Admission.Where(x => x.Disability == "V.I").Count();
                var idd = db.New_Admission.Where(x => x.Disability == "I.D.D").Count();
                var deact = db.Users.Where(x => x.IsActive == false).Count();

                dm.DashboardModel.total_histudents = hi;
                dm.DashboardModel.total_vistudents = vi;
                dm.DashboardModel.total_iddstudents = idd;
                dm.DashboardModel.total_deactivated_users = deact;
                return dm;
            }
        }
    }
}

