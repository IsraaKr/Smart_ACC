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
    
    public partial class T_LOCAL_ACCOUNT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_LOCAL_ACCOUNT_TYPE()
        {
            this.T_LOCAL_ACCOUNT = new HashSet<T_LOCAL_ACCOUNT>();
        }
    
        public decimal local_ac_type_id { get; set; }
        public Nullable<decimal> local_ac_type_code { get; set; }
        public string local_ac_type_name { get; set; }
        public string local_ac_type { get; set; }
        public Nullable<bool> local_ac_type_state { get; set; }
        public string local_ac_type_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LOCAL_ACCOUNT> T_LOCAL_ACCOUNT { get; set; }
    }
}