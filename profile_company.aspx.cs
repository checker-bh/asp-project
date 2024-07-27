using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class profile_company : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            if (Session["CompanyName"] != null)
            {
                lblSession.Text = "Welcome, " + Session["CompanyName"];
            }
            else if (Session["username"] != null)
            {
                Response.Redirect("~/profile_person.aspx");
            }
            else
            {
                Response.Redirect("~/login_company.aspx");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display_data();

        }
        void clear()
        {
            txtID.Text = "";
            txtCompanyName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update companies set comapnyname='" + txtCompanyName.Text + "',password='" + txtPassword.Text + "',confirm_password='" + txtConfirmPassword.Text + "',phone='" + txtPhone.Text + "',email='" + txtEmail.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from companies where companyname = '" + Session["CompanyName"] + "'";
            //cmd.CommandText = "select * from users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grviewCompanies.DataSource = dt;
            grviewCompanies.DataBind();



        }
        protected void grviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = grviewCompanies.SelectedRow.Cells[1].Text;
            txtCompanyName.Text = grviewCompanies.SelectedRow.Cells[2].Text;
            txtPassword.Text = grviewCompanies.SelectedRow.Cells[3].Text;
            txtConfirmPassword.Text = grviewCompanies.SelectedRow.Cells[4].Text;
            txtPhone.Text = grviewCompanies.SelectedRow.Cells[5].Text;
            txtEmail.Text = grviewCompanies.SelectedRow.Cells[6].Text;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from companies where comapnyname = '" + txtCompanyName.Text + "'";
            cmd.ExecuteNonQuery();
            //txtUsername.Text = "";
            //display_data();

            FormsAuthentication.SignOut();
            Session.Remove("CompanyName");
            Response.Redirect("~/signup_company.aspx");
        }
    }
}