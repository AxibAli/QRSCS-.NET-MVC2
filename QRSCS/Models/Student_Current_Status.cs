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
    
    public partial class Student_Current_Status
    {
        public int Id { get; set; }
        public Nullable<int> GR_NO { get; set; }
        public Nullable<int> Class { get; set; }
        public string Presentage { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
    
        public virtual New_Admission New_Admission { get; set; }
    }
}
