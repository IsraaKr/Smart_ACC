//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smart_ACC_DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_BOXES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_BOXES()
        {
            this.T_ITEMS = new HashSet<T_ITEMS>();
        }
    
        public decimal box_id { get; set; }
        public Nullable<decimal> box_code { get; set; }
        public string box_name { get; set; }
        public string box_nike_name { get; set; }
        public string box_type { get; set; }
        public Nullable<bool> box_state { get; set; }
        public string box_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ITEMS> T_ITEMS { get; set; }
    }
}
