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
    
    public partial class MpesaPayment
    {
        public int Id { get; set; }
        public string MerchantRequestID { get; set; }
        public string CheckoutRequestID { get; set; }
        public Nullable<int> ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string TransactionNumber { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string TransactionDate { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
