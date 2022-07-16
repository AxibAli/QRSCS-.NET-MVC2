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
    
    public partial class Medical_History
    {
        public int Medical_History_ID { get; set; }
        public int CaseHistory_ID { get; set; }
        public string Measles_Answer { get; set; }
        public string Whooping_Enough_Answer { get; set; }
        public string Mumps_Answer { get; set; }
        public string Chickenpox_Answer { get; set; }
        public string Pneumonia_Answer { get; set; }
        public string Diphtheria_Answer { get; set; }
        public string Polio_Answer { get; set; }
        public string Influenza_Answer { get; set; }
        public string Typhoid_Answer { get; set; }
        public string Convulsion_Answer { get; set; }
        public string Rheumatic_Fever_Answer { get; set; }
        public string High_Grade_Fever_Answer { get; set; }
        public Nullable<int> Measles_Age { get; set; }
        public Nullable<int> Whooping_Enough_Age { get; set; }
        public Nullable<int> Mumps_Age { get; set; }
        public Nullable<int> Chickenpox_Age { get; set; }
        public Nullable<int> Pneumonia_Age { get; set; }
        public Nullable<int> Diphtheria_Age { get; set; }
        public Nullable<int> Polio_Age { get; set; }
        public Nullable<int> Influenza_Age { get; set; }
        public Nullable<int> Typhoid_Age { get; set; }
        public Nullable<int> Convulsion_Age { get; set; }
        public Nullable<int> Rheumatic_Fever_Age { get; set; }
        public Nullable<int> High_Grade_Fever_Age { get; set; }
        public string Any_Other { get; set; }
    
        public virtual Case_History Case_History { get; set; }
    }
}