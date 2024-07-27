using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class Review1 : System.Web.UI.Page
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

            GridViewReview.DataSource = db.Reviews.ToList();
            GridViewReview.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                var myReveiw = db.Reviews.ToList();
                GridViewReview.DataSource = myReveiw;
                GridViewReview.DataBind();
            }
            else
            {
                var myReveiw = db.Reviews.Where(c => c.rating == txtSearch.Text).ToList();
                GridViewReview.DataSource = myReveiw;
                GridViewReview.DataBind();
            }
        }
    }
}