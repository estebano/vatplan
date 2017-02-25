using PlanVat.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vatplan.asp
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addProductForm_InsertItem()
        {
            var product = new PlanVat.Domain.DB.Products();
            TryUpdateModel(product);
            if (ModelState.IsValid)
            {
                try
                {
                    using (var context = new VatplanEntities())
                    {
                        context.Products.Add(product);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Pole {0} jest wymagane...", ex);
                }
            }
        }

        protected void addProductForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}