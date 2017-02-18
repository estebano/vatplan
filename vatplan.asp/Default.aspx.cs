using PlanVat.Domain.DB;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vatplan.asp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Products> productsGrid_GetData()
        {
            var q = from p in new VatplanEntities().Products 
                    orderby p.Name
                    select p;
            return q;
        }
    }
}