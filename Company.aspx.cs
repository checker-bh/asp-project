using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class Company1 : System.Web.UI.Page
    {
        BAHRAIN_TOURSEntities1 db = new BAHRAIN_TOURSEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                if (Session["username"].ToString() != "admin")
                {
                    Response.Redirect("~/login.aspx");
                }
                else
                {

                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }


            GridViewCompany.DataSource = db.Companies.ToList();
            GridViewCompany.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                var myCompany = db.Companies.ToList();
                GridViewCompany.DataSource = myCompany;
                GridViewCompany.DataBind();
            }
            else
            {
                var myCompany = db.Companies.Where(c => c.company_name == txtSearch.Text).ToList();
                GridViewCompany.DataSource = myCompany;
                GridViewCompany.DataBind();
            }
        }
    }
}