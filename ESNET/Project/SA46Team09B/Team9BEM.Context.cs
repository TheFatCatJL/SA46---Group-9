﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportFacilitySystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA46Team09BEntities : DbContext
    {
        public SA46Team09BEntities()
            : base("name=SA46Team09BEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AvailabilityCheck> AvailabilityChecks { get; set; }
        public virtual DbSet<FacilityInformation> FacilityInformations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<BookingTableInitialisation> BookingTableInitialisations { get; set; }
    }
}
