﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnarkRE.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SiteDBEntities : DbContext
    {
        public SiteDBEntities()
            : base("name=SiteDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<EscrowAccept> EscrowAccepts { get; set; }
        public DbSet<Escrow> Escrows { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<ContactMsg> ContactMsgs { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<ListingAddition> ListingAdditions { get; set; }
    }
}
