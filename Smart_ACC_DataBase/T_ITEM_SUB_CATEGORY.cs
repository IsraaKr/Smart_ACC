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
    
    public partial class T_ITEM_SUB_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_ITEM_SUB_CATEGORY()
        {
            this.T_ITEMS = new HashSet<T_ITEMS>();
        }
    
        public decimal sab_id { get; set; }
        public Nullable<decimal> sab_code { get; set; }
        public string sab_name { get; set; }
        public string sab_nike_name { get; set; }
        public string sab_type { get; set; }
        public string sab_note { get; set; }
        public Nullable<decimal> cat_id { get; set; }
    
        public virtual T_ITEM_CATIGORY T_ITEM_CATIGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ITEMS> T_ITEMS { get; set; }
    }
}