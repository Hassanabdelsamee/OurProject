//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDay1Demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamResult
    {
        public int ExamResult_ID { get; set; }
        public Nullable<int> ExamResult_StuID { get; set; }
        public Nullable<int> ExamResult_Examid { get; set; }
        public string ExamResult_Status { get; set; }
        public Nullable<decimal> ExamResult_degree { get; set; }
        public Nullable<System.DateTime> ExamResult_date { get; set; }
        public Nullable<bool> ExamResult_deletestatus { get; set; }
    }
}