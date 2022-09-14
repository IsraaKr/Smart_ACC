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
    
    public partial class T_BILL_IN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_BILL_IN()
        {
            this.T_BILL_IN_TRANSACTION = new HashSet<T_BILL_IN_TRANSACTION>();
        }
    
        public decimal bill_in_id { get; set; }
        public Nullable<decimal> bill_in_code { get; set; }
        public Nullable<System.DateTime> bill_in_date { get; set; }
        public Nullable<System.TimeSpan> bill_in_time { get; set; }
        public Nullable<decimal> bill_type_id { get; set; }
        public Nullable<decimal> cash_a_id { get; set; }
        public Nullable<decimal> bank_a_id { get; set; }
        public string cash_a_type { get; set; }
        public Nullable<decimal> local_acc_id { get; set; }
        public string bill_in_text { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<bool> discount_type { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> net { get; set; }
        public Nullable<bool> bill_in_state { get; set; }
        public string bill_in_note { get; set; }
        public Nullable<decimal> sale_inv_id { get; set; }
    
        public virtual T_BANK_ACOUNT T_BANK_ACOUNT { get; set; }
        public virtual T_BILL_TYPE T_BILL_TYPE { get; set; }
        public virtual T_CASH_ACOUNT T_CASH_ACOUNT { get; set; }
        public virtual T_INVOICE_SALES T_INVOICE_SALES { get; set; }
        public virtual T_LOCAL_ACCOUNT T_LOCAL_ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BILL_IN_TRANSACTION> T_BILL_IN_TRANSACTION { get; set; }
    }
}
