using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class Tourist1 : System.Web.UI.Page
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

            GridViewTourist.DataSource = db.Tourists.ToList();
            GridViewTourist.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                var myTourist = db.Tourists.ToList();
                GridViewTourist.DataSource = myTourist;
                GridViewTourist.DataBind();
            }
            else
            {
                var myTourist = db.Tourists.Where(c => c.full_name == txtSearch.Text).ToList();
                GridViewTourist.DataSource = myTourist;
                GridViewTourist.DataBind();
            }
        }
    }
}