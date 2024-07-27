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
    public partial class uc_signup : System.Web.UI.UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            divMessage.Attributes.Add("style", "padding:10px;margin-top:10px;");
            divMessage.Visible = false;


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtPhone.Text != "" && txtEmail.Text != "")
            {
                divMessage.Visible = true;
                string message = string.Format("You inserted into database your name is {0}, your password is {1}, your confirm password is {2}, your phone are {3}, and your email is {4}",
                txtUsername.Text, txtPassword.Text, txtConfirmPassword.Text, txtPhone.Text, txtEmail.Text);


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into users values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "')";
                cmd.ExecuteNonQuery();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";


                //display a message
                ltMessage.Text = message;


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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
    }
}