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
    
    public partial class STK_Transaction
    {
        public long ID { get; set; }
        public double openingStock { get; set; }
        public int stockId { get; set; }
        public int prodId { get; set; }
        public Nullable<double> rcvQty { get; set; }
        public Nullable<double> sellQty { get; set; }
        public Nullable<short> operation { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<long> sellId { get; set; }
    
        public virtual STK_tblStock STK_tblStock { get; set; }
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblSell tblSell { get; set; }
    }
}