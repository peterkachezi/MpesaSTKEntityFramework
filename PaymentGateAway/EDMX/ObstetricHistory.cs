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
    
    public partial class ObstetricHistory
    {
        public System.Guid Id { get; set; }
        public System.Guid TriageId { get; set; }
        public string Para { get; set; }
        public string Gravida { get; set; }
        public string EDD { get; set; }
        public string LMP { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid HospitalVisitId { get; set; }
        public System.Guid PatientId { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}