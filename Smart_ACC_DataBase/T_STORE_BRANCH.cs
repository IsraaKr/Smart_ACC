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
    
    public partial class T_STORE_BRANCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_STORE_BRANCH()
        {
            this.T_ITEM_STORE = new HashSet<T_ITEM_STORE>();
        }
    
        public decimal store_bra_id { get; set; }
        public Nullable<decimal> store_bra_code { get; set; }
        public Nullable<System.DateTime> store_bra_date { get; set; }
        public Nullable<bool> store_bra_state { get; set; }
        public string store_bra_note { get; set; }
        public Nullable<decimal> store_id { get; set; }
        public Nullable<decimal> bran_id { get; set; }
    
        public virtual T_BRANCH T_BRANCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ITEM_STORE> T_ITEM_STORE { get; set; }
        public virtual T_STORE T_STORE { get; set; }
    }
}