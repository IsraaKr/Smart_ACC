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
    
    public partial class T_CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_CUSTOMER()
        {
            this.T_INVOICE_SALES_BACK = new HashSet<T_INVOICE_SALES_BACK>();
            this.T_INVOICE_SALES_BACK_TRANSACTION = new HashSet<T_INVOICE_SALES_BACK_TRANSACTION>();
            this.T_INVOICE_SALES = new HashSet<T_INVOICE_SALES>();
            this.T_INVOICE_SALES_TRANSACTION = new HashSet<T_INVOICE_SALES_TRANSACTION>();
        }
    
        public decimal cust_id { get; set; }
        public Nullable<decimal> cust_code { get; set; }
        public string cust_name { get; set; }
        public string cust_nic_name { get; set; }
        public Nullable<System.DateTime> cust_start_date { get; set; }
        public string cust_major { get; set; }
        public string cust_adress { get; set; }
        public string cust_mobile { get; set; }
        public string cust_mobile1 { get; set; }
        public string tax_nation_num { get; set; }
        public Nullable<bool> cust_state { get; set; }
        public string cust_note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_BACK> T_INVOICE_SALES_BACK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_BACK_TRANSACTION> T_INVOICE_SALES_BACK_TRANSACTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES> T_INVOICE_SALES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_TRANSACTION> T_INVOICE_SALES_TRANSACTION { get; set; }
    }
}