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
    
    public partial class T_BOND_OUT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_BOND_OUT()
        {
            this.T_BOND_OUT_ITEM = new HashSet<T_BOND_OUT_ITEM>();
        }
    
        public decimal out_bond_id { get; set; }
        public Nullable<decimal> out_bond_code { get; set; }
        public Nullable<System.DateTime> out_bond_date { get; set; }
        public Nullable<System.TimeSpan> out_bond_time { get; set; }
        public string out_bond_text { get; set; }
        public Nullable<bool> out_bond_state { get; set; }
        public string out_bond_note { get; set; }
        public Nullable<decimal> bond_type_id { get; set; }
        public Nullable<decimal> sale_inv_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_BOND_OUT_ITEM> T_BOND_OUT_ITEM { get; set; }
        public virtual T_BONDS_TYPE T_BONDS_TYPE { get; set; }
        public virtual T_INVOICE_SALES T_INVOICE_SALES { get; set; }
    }
}