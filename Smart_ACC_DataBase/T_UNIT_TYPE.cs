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
    
    public partial class T_UNIT_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_UNIT_TYPE()
        {
            this.T_INVOICE_PAY_BONES = new HashSet<T_INVOICE_PAY_BONES>();
            this.T_INVOICE_PAY_ITEM = new HashSet<T_INVOICE_PAY_ITEM>();
            this.T_INVOICE_PAY_ITEM_BACK = new HashSet<T_INVOICE_PAY_ITEM_BACK>();
            this.T_INVOICE_SALES_BONES = new HashSet<T_INVOICE_SALES_BONES>();
            this.T_INVOICE_SALES_ITEM = new HashSet<T_INVOICE_SALES_ITEM>();
            this.T_INVOICE_SALES_ITEM_BACK = new HashSet<T_INVOICE_SALES_ITEM_BACK>();
        }
    
        public decimal unit_type_id { get; set; }
        public Nullable<decimal> unit_type_code { get; set; }
        public string unit_type_name { get; set; }
        public string unit_type_nike_name { get; set; }
        public byte[] unit_type_type { get; set; }
        public Nullable<bool> unit_type_state { get; set; }
        public string unit_type_note { get; set; }
        public Nullable<decimal> unit_size_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_PAY_BONES> T_INVOICE_PAY_BONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_PAY_ITEM> T_INVOICE_PAY_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_PAY_ITEM_BACK> T_INVOICE_PAY_ITEM_BACK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_BONES> T_INVOICE_SALES_BONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_ITEM> T_INVOICE_SALES_ITEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_INVOICE_SALES_ITEM_BACK> T_INVOICE_SALES_ITEM_BACK { get; set; }
        public virtual T_UNIT_SIZE T_UNIT_SIZE { get; set; }
    }
}
