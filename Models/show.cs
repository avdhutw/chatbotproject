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
    using System.ComponentModel.DataAnnotations;

    public partial class show
    {
        public int channel_id { get; set; }
        [Required(ErrorMessage ="Please enter channel name")]
        public string channel_name { get; set; }
        [Required(ErrorMessage = "Please enter show name")]
        public string show_name { get; set; }
    }
}
