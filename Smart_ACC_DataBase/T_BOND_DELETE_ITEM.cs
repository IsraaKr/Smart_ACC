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
    
    public partial class T_BOND_DELETE_ITEM
    {
        public decimal delet_bond_item_id { get; set; }
        public Nullable<decimal> delet_bond_item_code { get; set; }
        public Nullable<System.DateTime> delet_bond_item_date { get; set; }
        public Nullable<System.TimeSpan> delet_bond_item_time { get; set; }
        public Nullable<int> delet_bond_item_count { get; set; }
        public string delet_bond_item_text { get; set; }
        public Nullable<bool> delet_bond_item_state { get; set; }
        public string delet_bond_item_note { get; set; }
        public Nullable<decimal> item_id { get; set; }
        public Nullable<decimal> delet_bond_id { get; set; }
    
        public virtual T_BOND_DELETE T_BOND_DELETE { get; set; }
        public virtual T_ITEMS T_ITEMS { get; set; }
    }
}
