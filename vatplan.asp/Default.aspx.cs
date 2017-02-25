using PlanVat.Domain.DB;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
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

        // The id parameter name should match the DataKeyNames value set on the control
        public void productsGrid_DeleteItem(int id)
        {
            using (var context = new VatplanEntities())
            {
                var item = new Products() { Id = id };
                context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", string.Format("Product o identyfikatorze {0} nie został znaleziony."
                        , id));
                }
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void productsGrid_UpdateItem(int id)
        {
            using (var context = new VatplanEntities())
            {
                PlanVat.Domain.DB.Products item = context.Products.Find(id);
                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Produkt o identyfikatorze {0} nie został znaleziony", id));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    // Save changes here, e.g. MyDataLayer.SaveChanges();
                    context.SaveChanges();
                }

            }
        }

        private bool tableCopied = false;
        private DataTable originalDataTable = null;
        private static readonly string ORIGINAL_VALUES_DATA_TABLE = "originalValuesDataTable";
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType != DataControlRowType.DataRow)
            {
                return;
            }
            if (tableCopied)
            {
                return;
            }
            originalDataTable = ((DataRowView)e.Row.DataItem).Row.Table.Copy();
            ViewState[ORIGINAL_VALUES_DATA_TABLE] = originalDataTable;
            tableCopied = true;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            originalDataTable = (DataTable)ViewState[ORIGINAL_VALUES_DATA_TABLE];

            foreach (GridViewRow gridRow in GridView1.Rows)
            {
                if (IsRowModified(gridRow))
                {
                    GridView1.UpdateRow(gridRow.RowIndex, false);
                }
                tableCopied = false;
                GridView1.DataBind();
            }
        }

        private bool IsRowModified(GridViewRow r)
        {
            int currentId = Convert.ToInt32(GridView1.DataKeys[r.RowIndex].Value);
            DataRow originalRow =
                originalDataTable.Select(string.Format("iD = {0}", currentId))[0];

            string currentName = ((TextBox)r.FindControl("NameTxtBox")).Text;
            if (!currentName.Equals(originalRow["Name"])) { return true; }

            string currentDedscription = ((TextBox)r.FindControl("DescriptionTextBox")).Text;
            if (!currentDedscription.Equals(originalRow["Description"])) { return true; }

            string currentPKWiU = ((TextBox)r.FindControl("PkwiuTextBox")).Text;
            if (!currentPKWiU.Equals(originalRow["PKWiU"])) { return true; }

            return false;
        }
    }
}