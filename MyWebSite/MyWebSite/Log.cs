//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebSite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int LogID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Category { get; set; }
        public string Cat_Description { get; set; }
    
        public virtual User User { get; set; }
    }
}