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
    
    public partial class tblDue
    {
        public long ID { get; set; }
        public int partyId { get; set; }
        public Nullable<long> buyId { get; set; }
        public Nullable<long> costingId { get; set; }
        public Nullable<double> openingBalance { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<byte> isActive { get; set; }
    
        public virtual tblBuy tblBuy { get; set; }
        public virtual tblCostingSource tblCostingSource { get; set; }
        public virtual tblParty tblParty { get; set; }
    }
}
