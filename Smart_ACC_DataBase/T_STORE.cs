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
    
    public partial class T_STORE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_STORE()
        {
            this.T_STORE_BRANCH = new HashSet<T_STORE_BRANCH>();
        }
    
        public decimal store_id { get; set; }
        public Nullable<decimal> store_code { get; set; }
        public string store_name { get; set; }
        public string store_nike_name { get; set; }
        public Nullable<System.DateTime> store_start_date { get; set; }
        public string store_location { get; set; }
        public string store_ex_location { get; set; }
        public string store_type { get; set; }
        public string store_mobile { get; set; }
        public string store_fax { get; set; }
        public Nullable<bool> store_state { get; set; }
        public string store_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_STORE_BRANCH> T_STORE_BRANCH { get; set; }
    }
}