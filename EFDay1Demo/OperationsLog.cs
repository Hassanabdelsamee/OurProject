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
    
    public partial class OperationsLog
    {
        public int OperationLog_ID { get; set; }
        public string OperationLog_Description { get; set; }
        public Nullable<int> OperationLog_User_ID { get; set; }
        public System.DateTime OperationLog_Date { get; set; }
        public Nullable<int> OperationLog_TransactionTypeID { get; set; }
    
        public virtual User User { get; set; }
    }
}