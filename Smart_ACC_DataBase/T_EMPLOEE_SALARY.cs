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
    
    public partial class T_EMPLOEE_SALARY
    {
        public decimal emp_s_id { get; set; }
        public Nullable<decimal> emp_s_code { get; set; }
        public string emp_s_name { get; set; }
        public Nullable<decimal> emp_s_salary { get; set; }
        public Nullable<decimal> emp_s_discount { get; set; }
        public Nullable<decimal> emp_s_bonas { get; set; }
        public Nullable<decimal> emp_s_nets { get; set; }
        public Nullable<decimal> emp_id { get; set; }
        public Nullable<bool> emp_s_state { get; set; }
        public string emp_s_note { get; set; }
    
        public virtual T_EMPLOEE T_EMPLOEE { get; set; }
    }
}
