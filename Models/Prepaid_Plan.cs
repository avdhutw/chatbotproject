//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoofuserplans.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prepaid_Plan
    {
        public int Plan_id { get; set; }
        public string Plan_name { get; set; }
        public string Noof_day { get; set; }
        public string Datalimit_per { get; set; }
        public Nullable<int> Noof_sms { get; set; }
        public string Noof_calls { get; set; }
        public Nullable<bool> Isunlimitedcalling_enabled { get; set; }
    }
}