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
    
    public partial class T_BILL_OUT_TRANSACTION
    {
        public decimal bill_out_tra_id { get; set; }
        public Nullable<decimal> bill_out_tra_code { get; set; }
        public Nullable<System.DateTime> bill_out_tra_date { get; set; }
        public Nullable<System.TimeSpan> bill_out_tra_time { get; set; }
        public string bill_out_tra_text { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> net { get; set; }
        public Nullable<decimal> curncy_id { get; set; }
        public Nullable<decimal> bran_id { get; set; }
        public Nullable<bool> bill_out_tra_state { get; set; }
        public string bill_out_tra_note { get; set; }
        public Nullable<decimal> bill_out_id { get; set; }
    
        public virtual T_BILL_OUT T_BILL_OUT { get; set; }
        public virtual T_BRANCH T_BRANCH { get; set; }
        public virtual T_CURNCY T_CURNCY { get; set; }
    }
}
