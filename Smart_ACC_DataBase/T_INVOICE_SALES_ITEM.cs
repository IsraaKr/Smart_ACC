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
    
    public partial class T_INVOICE_SALES_ITEM
    {
        public decimal sal_inv_item_id { get; set; }
        public Nullable<decimal> sal_inv_item_code { get; set; }
        public Nullable<System.DateTime> sal_inv_item_date { get; set; }
        public Nullable<System.TimeSpan> sal_inv_item_time { get; set; }
        public string sal_inv_item_text { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> sal_price { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<bool> dicount_type { get; set; }
        public Nullable<decimal> discount_total { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<decimal> item_id { get; set; }
        public Nullable<decimal> unit_size_id { get; set; }
        public Nullable<decimal> unit_type_id { get; set; }
        public Nullable<bool> sal_inv_item_state { get; set; }
        public string sal_inv_item_note { get; set; }
        public Nullable<decimal> sale_inv_id { get; set; }
    
        public virtual T_INVOICE_SALES T_INVOICE_SALES { get; set; }
        public virtual T_ITEMS T_ITEMS { get; set; }
        public virtual T_UNIT_SIZE T_UNIT_SIZE { get; set; }
        public virtual T_UNIT_TYPE T_UNIT_TYPE { get; set; }
    }
}
