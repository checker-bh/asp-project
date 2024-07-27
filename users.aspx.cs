using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace BAHRAIN_TOURS
{
    public partial class users : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (Session["username"].ToString() != "admin")
                {
                    Response.Redirect("~/login_person.aspx");
                }
                else
                {
                    lblSession.Text = "Welcome, " + Session["username"];
                }
            }
            else
            {
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
            txtUsername.Text = "";
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
            cmd.CommandText = "insert into users values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtApproved.Text + "','" + txtDesc.InnerText + "')";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from users where username = '" + txtUsername.Text + "'";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update users set username='" + txtUsername.Text + "',password='" + txtPassword.Text + "',confirm_password='" + txtConfirmPassword.Text + "',phone='" + txtPhone.Text + "',email='" + txtEmail.Text + "',approved='" + txtApproved.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            display_data();
        }

        protected void grviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = grviewUsers.SelectedRow.Cells[1].Text;
            txtUsername.Text = grviewUsers.SelectedRow.Cells[2].Text;
            txtPassword.Text = grviewUsers.SelectedRow.Cells[3].Text;
            txtConfirmPassword.Text = grviewUsers.SelectedRow.Cells[4].Text;
            txtPhone.Text = grviewUsers.SelectedRow.Cells[5].Text;
            txtEmail.Text = grviewUsers.SelectedRow.Cells[6].Text;
            txtApproved.Text = grviewUsers.SelectedRow.Cells[7].Text;
            txtDesc.InnerText = grviewUsers.SelectedRow.Cells[8].Text;
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grviewUsers.DataSource = dt;
            grviewUsers.DataBind();
        }
    }
}