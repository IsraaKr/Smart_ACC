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
    
    public partial class T_ITEM_CATIGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_ITEM_CATIGORY()
        {
            this.T_ITEM_SUB_CATEGORY = new HashSet<T_ITEM_SUB_CATEGORY>();
        }
    
        public decimal cat_id { get; set; }
        public Nullable<decimal> cat_code { get; set; }
        public string cat_name { get; set; }
        public string cat_nike_name { get; set; }
        public Nullable<bool> cat_state { get; set; }
        public string cat_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ITEM_SUB_CATEGORY> T_ITEM_SUB_CATEGORY { get; set; }
    }
}
