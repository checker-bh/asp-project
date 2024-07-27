using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (Session["username"].ToString() == "admin")
                {
                    //admin 
                    admin_area.Visible = true;
                }
                else
                {
                    //normal user
                    admin_area.Visible = false;
                }
            }
            else
            {
                admin_area.Visible = false;
                // Response.Redirect("~/login.aspx");
            }
        }
    }
}