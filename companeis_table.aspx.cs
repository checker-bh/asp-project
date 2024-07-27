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
    public partial class companeis_table : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (Session["username"].ToString() != "admin")
                {
                    //normal user
                    Response.Redirect("~/login.aspx");
                }
                else
                {
                    //admin
                    lblSession.Text = "Welcome, " + Session["username"];
                }
            }
            else
            {
                //not a user
                Response.Redirect("~/login_person.aspx");
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
            txtApproved.Text = "";
            txtDesc.InnerText = "";

        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into companies values('" + txtCompanyName.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtApproved.Text + "','" + txtDesc.InnerText + "')";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from companies where comapnyname = '" + txtCompanyName.Text + "'";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update companies set comapnyname='" + txtCompanyName.Text + "',password='" + txtPassword.Text + "',confirm_password='" + txtConfirmPassword.Text + "',phone='" + txtPhone.Text + "',email='" + txtEmail.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "";
            cmd.CommandText = "update companies set companyname='" + txtCompanyName.Text + "',password='" + txtPassword.Text + "',confirm_password='" + txtConfirmPassword.Text + "',phone='" + txtPhone.Text + "',email='" + txtEmail.Text + "',approved='" + txtApproved.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            display_data();
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from companies";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grviewUsers.DataSource = dt;
            grviewUsers.DataBind();
        }

        protected void grviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = grviewUsers.SelectedRow.Cells[1].Text;
            txtCompanyName.Text = grviewUsers.SelectedRow.Cells[2].Text;
            txtPassword.Text = grviewUsers.SelectedRow.Cells[3].Text;
            txtConfirmPassword.Text = grviewUsers.SelectedRow.Cells[4].Text;
            txtPhone.Text = grviewUsers.SelectedRow.Cells[5].Text;
            txtEmail.Text = grviewUsers.SelectedRow.Cells[6].Text;
            txtApproved.Text = grviewUsers.SelectedRow.Cells[7].Text;
            txtDesc.InnerText = grviewUsers.SelectedRow.Cells[8].Text;
        }
    }
}