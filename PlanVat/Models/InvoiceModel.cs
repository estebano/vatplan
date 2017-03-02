using PlanVat.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanVat.Models
{
    public class InvoiceModel
    {
        public IEnumerable<Invoices> Invoices { get; private set; }
        public InvoiceModel(IEnumerable<Invoices> invoices)
        {

        }
    }
}