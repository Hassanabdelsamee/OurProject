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
    
    public partial class Section
    {
        public int Section_ID { get; set; }
        public Nullable<int> Section_StageID { get; set; }
        public string Section_Name { get; set; }
        public Nullable<bool> Section_Deletestatus { get; set; }
    
        public virtual Stage Stage { get; set; }
    }
}