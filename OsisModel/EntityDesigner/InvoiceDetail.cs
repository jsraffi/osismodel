//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OsisModel.EntityDesigner
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        public int InvoiceRefID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
