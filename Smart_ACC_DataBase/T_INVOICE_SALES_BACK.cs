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
    
    public partial class T_INVOICE_SALES_BACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_INVOICE_SALES_BACK()
        {
            this.T_INVOICE_SALES_BACK_TRANSACTION = new HashSet<T_INVOICE_SALES_BACK_TRANSACTION>();
        }
    
        public decimal sal_inv_b_id { get; set; }
        public Nullable<decimal> sal_inv_b_code { get; set; }
        public Nullable<System.DateTime> sal_inv_b_date { get; set; }
        public Nullable<System.TimeSpan> sal_inv_b_time { get; set; }
        public Nullable<System.DateTime> sale_inv_b_pay_date { get; set; }
        public string sale_inv_b_text { get; set; }
        public Nullable<decimal> cust_id { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> tax_per { get; set; }
        public Nullable<decimal> tax_amount { get; set; }
        public Nullable<decimal> tax_plus { get; set; }
        public Nullable<decimal> discount_type { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> net { get; set; }
        public string sale_inv_b_adress { get; set; }
        public Nullable<decimal> pay_type_id { get; set; }
        public Nullable<decimal> inv_type_id { get; set; }
        public Nullable<bool> sale_inv_state { get; set; }
        public string sale_inv_note { get; set; }
        public Nullable<decimal> sale_inv_id { get; set; }
    
        public virtual T_CUSTOMER T_CUSTOMER { get; set; }
        public virtual T_INVOICE_PAY_TYPE T_INVOICE_PAY_TYPE { get; set; }
        public virtual T_INVOICE_SALES T_INVOICE_SALES { get; set; }
        public virtual T_INVOICE_TYPE T_INVOICE_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_BACK_TRANSACTION> T_INVOICE_SALES_BACK_TRANSACTION { get; set; }
        public virtual T_INVOICE_SALES_ITEM_BACK T_INVOICE_SALES_ITEM_BACK { get; set; }
    }
}
