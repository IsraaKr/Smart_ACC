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
    
    public partial class T_ITEM_PICTURE
    {
        public decimal pic_id { get; set; }
        public Nullable<decimal> pic_code { get; set; }
        public string pic_nam { get; set; }
        public string pic_location { get; set; }
        public Nullable<bool> pic_state { get; set; }
        public string pic_note { get; set; }
        public Nullable<decimal> item_id { get; set; }
    
        public virtual T_ITEMS T_ITEMS { get; set; }
    }
}
