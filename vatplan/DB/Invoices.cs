//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vatplan.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoices()
        {
            this.InvoiceItems = new HashSet<InvoiceItems>();
        }
    
        public int Id { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime SaleDate { get; set; }
        public int ContractorId { get; set; }
    
        public virtual Contractors Contractors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
    }
}
