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
    
    public partial class TreatmentPlan_PT
    {
        public int TreatmentPlanPT_ID { get; set; }
        public int PT_ID { get; set; }
        public string LongTerm_Goal { get; set; }
        public string ShortTerm_Goal { get; set; }
        public string Recommendations { get; set; }
    
        public virtual Physiotherapy Physiotherapy { get; set; }
    }
}
