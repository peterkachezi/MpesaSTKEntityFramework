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
    
    public partial class PatientNextOfKin
    {
        public System.Guid Id { get; set; }
        public System.Guid PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Relationship { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
