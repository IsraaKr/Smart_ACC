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
    
    public partial class T_BOND_OUT_ITEM
    {
        public decimal out_bond_item_id { get; set; }
        public Nullable<decimal> out_bond_item_code { get; set; }
        public Nullable<System.DateTime> out_bond_item_date { get; set; }
        public Nullable<System.TimeSpan> out_bond_item_time { get; set; }
        public Nullable<int> out_bond_item_count { get; set; }
        public string out_bond_item_text { get; set; }
        public Nullable<bool> out_bond_item_state { get; set; }
        public string out_bond_item_note { get; set; }
        public Nullable<decimal> item_id { get; set; }
        public Nullable<decimal> out_bond_id { get; set; }
    
        public virtual T_BOND_OUT T_BOND_OUT { get; set; }
        public virtual T_ITEMS T_ITEMS { get; set; }
    }
}
