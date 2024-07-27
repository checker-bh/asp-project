using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (Session["username"].ToString() == "admin")
                {
                    //admin 
                }
                else
                {
                    //normal user
                }
            }
            else
            {
                // Response.Redirect("~/login.aspx");
            }

            //connection
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();


            divH1.Visible = true;
            divH1.Attributes.Add("style", "color:grey;font-weight:bold;text-align:center;");
            divMessage.Attributes.Add("style", "padding:10px;");
            divMessage.Visible = false;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtAge.Text != "" && txtMsg.InnerText != "" && ddlPackage.SelectedValue != "")
            {
                divMessage.Visible = true;
                string message = string.Format("You inserted into database your name is {0}, your Email is {1}, your Age is {2}, your notes are {3}, and your package is {4}",
                txtName.Text, txtEmail.Text, txtAge.Text, txtMsg.InnerText, ddlPackage.SelectedValue);

                //insert into database
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into contact values('" + txtName.Text + "','" + txtEmail.Text + "','" + txtAge.Text + "','" + txtMsg.InnerText + "','" + ddlPackage.SelectedItem.Text + "')";
                cmd.ExecuteNonQuery();
                txtName.Text = "";
                txtEmail.Text = "";
                txtAge.Text = "";
                txtMsg.InnerText = "";
                //display a message
                ltMessage.Text = message;

                //connection close
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            else
            {
                divMessage.Visible = true;
                ltMessage.Text = "All fileds are required !!";
            }
        }
    }
}