using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class login_company : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select password from companies where companyname = '" + txtCompanyName.Text + "' and approved = 1", con);
            con.Open();
            dr = cmd.ExecuteReader();
            bool flag = false;
            while (dr.Read())
            {
                if (dr[0].Equals(txtpassword.Text))
                {
                    Session["CompanyName"] = txtCompanyName.Text;
                    lblmsg.Text = "Successfully login !!";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                    flag = true;
                    Response.Redirect("~/welcome_company.aspx");
                }
            }
            if (!flag)
            {
                lblmsg.Text = "company name or password is incorrect or u are not aprroved !!";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();
        }
    }

}