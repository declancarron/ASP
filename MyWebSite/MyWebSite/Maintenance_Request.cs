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
    
    public partial class Maintenance_Request
    {
        public int RequestID { get; set; }
        public string Request_Desc { get; set; }
        public Nullable<int> Build_Num { get; set; }
        public Nullable<int> VillageID { get; set; }
        public Nullable<System.DateTime> Submission_Date { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Remediation_Date { get; set; }
        public Nullable<int> ResidentID { get; set; }
        public Nullable<int> ApartmentID { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Resident Resident { get; set; }
        public virtual Village Village { get; set; }
    }
}
