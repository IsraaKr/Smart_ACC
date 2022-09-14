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
    
    public partial class T_CASH_ACOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_CASH_ACOUNT()
        {
            this.T_BILL_IN = new HashSet<T_BILL_IN>();
            this.T_BILL_OUT = new HashSet<T_BILL_OUT>();
            this.T_CASH_TRANSACTION = new HashSet<T_CASH_TRANSACTION>();
        }
    
        public decimal cash_a_id { get; set; }
        public byte[] cash_a_name { get; set; }
        public Nullable<System.DateTime> cash_a_start_date { get; set; }
        public Nullable<decimal> cash_a_start_balance { get; set; }
        public Nullable<decimal> cash_a_zero_balance { get; set; }
        public Nullable<decimal> cash_a_balance { get; set; }
        public Nullable<bool> cash_a_state { get; set; }
        public Nullable<decimal> cash_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BILL_IN> T_BILL_IN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BILL_OUT> T_BILL_OUT { get; set; }
        public virtual T_MAIN_CASH T_MAIN_CASH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CASH_TRANSACTION> T_CASH_TRANSACTION { get; set; }
    }
}