//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Johan.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPayment
    {
        public int ID { get; set; }
        public int partyId { get; set; }
        public Nullable<long> buyId { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<double> paidAmount { get; set; }
        public Nullable<double> totalAmount { get; set; }
        public Nullable<double> discount { get; set; }
    
        public virtual tblBuy tblBuy { get; set; }
        public virtual tblParty tblParty { get; set; }
    }
}
