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
    
    public partial class Rental
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rental()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public int RentalID { get; set; }
        public Nullable<System.DateTime> Rental_Date { get; set; }
        public Nullable<int> ApartmentID { get; set; }
        public Nullable<int> ResidentID { get; set; }
        public Nullable<System.DateTime> Rental_Term { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public byte[] Last_Update { get; set; }
    
        public virtual Apartment Apartment { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual Resident Resident { get; set; }
    }
}