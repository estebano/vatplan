//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanVat.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItems
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
    
        public virtual Invoices Invoices { get; set; }
        public virtual Products Products { get; set; }
    }
}
