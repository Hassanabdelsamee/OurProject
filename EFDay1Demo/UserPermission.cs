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
    
    public partial class UserPermission
    {
        public int UserPage_ID { get; set; }
        public int User_ID { get; set; }
        public int Page_ID { get; set; }
        public Nullable<int> UserPage_USerID { get; set; }
    
        public virtual Page Page { get; set; }
        public virtual User User { get; set; }
    }
}