//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentGateAway.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public string PhysicalAddress { get; set; }
        public string Email { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCode { get; set; }
        public int CountyId { get; set; }
        public byte Status { get; set; }
        public byte[] Logo { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
