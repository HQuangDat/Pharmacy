//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medical_Supplie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medical_Supplie()
        {
            this.Bill_Supplie = new HashSet<Bill_Supplie>();
        }
    
        public int Medical_Supplie_ID { get; set; }
        public string Medical_Supplie_Name { get; set; }
        public Nullable<int> Medical_Supplie_Quantity { get; set; }
        public Nullable<decimal> Medical_Supplie_Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Supplie> Bill_Supplie { get; set; }
    }
}
