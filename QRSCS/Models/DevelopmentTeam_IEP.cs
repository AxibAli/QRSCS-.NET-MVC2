//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QRSCS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DevelopmentTeam_IEP
    {
        public int DevelopmentTeam_ID { get; set; }
        public int IEPlan_ID { get; set; }
        public string DevelopmentTeam_Name_1 { get; set; }
        public string DevelopmentTeam_Name_2 { get; set; }
        public string DevelopmentTeam_Name_3 { get; set; }
        public string DevelopmentTeam_Name_4 { get; set; }
        public string DevelopmentTeam_Name_5 { get; set; }
        public string DevelopmentTeam_Name_6 { get; set; }
        public string DevelopmentTeam_Name_7 { get; set; }
        public string Position_1 { get; set; }
        public string Position_2 { get; set; }
        public string Position_3 { get; set; }
        public string Position_4 { get; set; }
        public string Position_5 { get; set; }
        public string Position_6 { get; set; }
        public string Position_7 { get; set; }
    
        public virtual IEPlan IEPlan { get; set; }
    }
}