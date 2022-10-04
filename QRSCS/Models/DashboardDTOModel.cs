using QRSCS.Common.Dashboard;
using QRSCS.Common.CaseHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QRSCS.Models
{
    public class DashboardDTOModel
    {
        public DashboardModel DashboardModel { get; set; }
        public CreateUserModel CreateUserModel { get; set; }
    }
}