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
    
    public partial class StudentPaysNew
    {
        public int StudentPay_ID { get; set; }
        public Nullable<int> StudentPay_catid { get; set; }
        public Nullable<int> StudentPay_stuid { get; set; }
        public Nullable<System.DateTime> StudentPay_Date { get; set; }
        public string StudentPay_PayStatus { get; set; }
        public Nullable<decimal> StudentPay_catcost { get; set; }
        public Nullable<decimal> StudentPay_discount { get; set; }
        public Nullable<decimal> StudentPay_notesscost { get; set; }
        public Nullable<decimal> StudentPay_Netvalue { get; set; }
        public Nullable<decimal> StudentPay_Paid { get; set; }
        public Nullable<decimal> StudentPay_Remaining { get; set; }
        public Nullable<int> StudentPay_cashid { get; set; }
        public Nullable<bool> StudentPay_Deletestatus { get; set; }
    }
}