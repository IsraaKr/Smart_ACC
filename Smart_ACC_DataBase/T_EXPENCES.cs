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
    
    public partial class T_EXPENCES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_EXPENCES()
        {
            this.T_EXPENCES_ACCOUNT = new HashSet<T_EXPENCES_ACCOUNT>();
        }
    
        public decimal exp_id { get; set; }
        public Nullable<decimal> exp_code { get; set; }
        public string exp_name { get; set; }
        public Nullable<decimal> exp_max_value { get; set; }
        public Nullable<bool> exp_exp_state { get; set; }
        public string exp_note { get; set; }
        public Nullable<decimal> eex_type_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_EXPENCES_ACCOUNT> T_EXPENCES_ACCOUNT { get; set; }
        public virtual T_EXPENSES_TYPE T_EXPENSES_TYPE { get; set; }
    }
}