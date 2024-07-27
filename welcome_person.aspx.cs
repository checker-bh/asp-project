﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class welcome_person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (Session["username"].ToString() != "admin")
                {

                    //normal user
                    lblMsg.Text = "Welcome to our web site " + Session["username"];
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    //admin
                    lblMsg.Text = "Welcome to our web site " + Session["username"];
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Response.Redirect("~/login_person.aspx");
            }
        }
    }
}