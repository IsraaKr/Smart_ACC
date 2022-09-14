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
    
    public partial class T_LOCAL_ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_LOCAL_ACCOUNT()
        {
            this.T_BILL_IN = new HashSet<T_BILL_IN>();
            this.T_BILL_OUT = new HashSet<T_BILL_OUT>();
        }
    
        public decimal local_acc_id { get; set; }
        public Nullable<decimal> local_acc_code { get; set; }
        public Nullable<System.DateTime> local_acc_date { get; set; }
        public Nullable<decimal> local_acc_balance { get; set; }
        public Nullable<decimal> local_acc_low { get; set; }
        public Nullable<decimal> local_acc_max { get; set; }
        public Nullable<decimal> main_acc_id { get; set; }
        public Nullable<bool> local_acc_state { get; set; }
        public string local_acc_note { get; set; }
        public Nullable<decimal> local_ac_type_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BILL_IN> T_BILL_IN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BILL_OUT> T_BILL_OUT { get; set; }
        public virtual T_LOCAL_ACCOUNT_TYPE T_LOCAL_ACCOUNT_TYPE { get; set; }
    }
}
