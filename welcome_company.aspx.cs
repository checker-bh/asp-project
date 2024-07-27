using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class welcome_company : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CompanyName"] == null)
            {
                Response.Redirect("~/login_company.aspx");
            }
            else
            {
                lblMsg.Text = "Welcome " + Session["CompanyName"];
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}