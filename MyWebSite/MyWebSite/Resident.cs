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
    
    public partial class Resident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resident()
        {
            this.Maintenance_Request = new HashSet<Maintenance_Request>();
        }
    
        public int ResidentID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> College_ID { get; set; }
        public string Address { get; set; }
        public Nullable<int> Dept_ID { get; set; }
        public string Tel_Num { get; set; }
        public string Martial_Status { get; set; }
    
        public virtual College College { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance_Request> Maintenance_Request { get; set; }
    }
}