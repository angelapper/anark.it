//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Listing
    {
        public Listing()
        {
            this.Escrows = new HashSet<Escrow>();
            this.Feedbacks = new HashSet<Feedback>();
            this.ContactMsgs = new HashSet<ContactMsg>();
            this.ListingAdditions = new HashSet<ListingAddition>();
        }
    
        public System.Guid ListingId { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsApproved { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal PriceBTC { get; set; }
        public decimal PriceUSD { get; set; }
        public string PegCurrency { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public short CatId { get; set; }
        public decimal PriceCUR { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPrivate { get; set; }
        public Nullable<System.DateTime> FeaturedDate { get; set; }
        public Nullable<int> QtyAvail { get; set; }
        public Nullable<int> QtySold { get; set; }
    
        public virtual Catagory Catagory { get; set; }
        public virtual ICollection<Escrow> Escrows { get; set; }
        public virtual User UserProfile { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<ContactMsg> ContactMsgs { get; set; }
        public virtual ICollection<ListingAddition> ListingAdditions { get; set; }
    }
}
