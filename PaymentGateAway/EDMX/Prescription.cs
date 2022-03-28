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
    
    public partial class Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            this.PrescriptionDetails = new HashSet<PrescriptionDetail>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid PatientId { get; set; }
        public string VisitCode { get; set; }
        public System.DateTime CreateDate { get; set; }
        public byte MedicineDispatchStatus { get; set; }
        public string CreatedBy { get; set; }
        public string CaseHistory { get; set; }
        public string Note { get; set; }
        public string PrescriptionFor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
    }
}
