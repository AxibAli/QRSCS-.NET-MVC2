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
    
    public partial class PhysicalAssessment_PT
    {
        public int PhysicalAssessmentPT_ID { get; set; }
        public int PT_ID { get; set; }
        public string Contracture_Deformity { get; set; }
        public string Muscle_Tone { get; set; }
        public string UpperLimbs_Strength { get; set; }
        public string UpperLimbs_Rom { get; set; }
        public string LowerLimbs_Strength { get; set; }
        public string LowerLimbs_Rom { get; set; }
    
        public virtual Physiotherapy Physiotherapy { get; set; }
    }
}