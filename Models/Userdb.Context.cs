﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mobile_appEntities2 : DbContext
    {
        public mobile_appEntities2()
            : base("name=mobile_appEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Prepaid_Plan> Prepaid_Plan { get; set; }
        public virtual DbSet<show> shows { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
