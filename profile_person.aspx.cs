﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class profile_person : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            if (Session["username"] != null)
            {
                lblSession.Text = "Welcome, " + Session["username"];
            }
            else if (Session["CompanyName"] != null)
            {
                Response.Redirect("~/profile_company.aspx");
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update users set username='" + txtUsername.Text + "',password='" + txtPassword.Text + "',confirm_password='" + txtConfirmPassword.Text + "',phone='" + txtPhone.Text + "',email='" + txtEmail.Text + "' where id=" + Convert.ToInt32(txtID.Text) + "";
            cmd.ExecuteNonQuery();
            txtID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            display_data();
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username = '" + Session["username"] + "'";
            //cmd.CommandText = "select * from users";
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
            txtUsername.Text = grviewUsers.SelectedRow.Cells[2].Text;
            txtPassword.Text = grviewUsers.SelectedRow.Cells[3].Text;
            txtConfirmPassword.Text = grviewUsers.SelectedRow.Cells[4].Text;
            txtPhone.Text = grviewUsers.SelectedRow.Cells[5].Text;
            txtEmail.Text = grviewUsers.SelectedRow.Cells[6].Text;

            btnUpdate.Visible = true;
            btnDelete.Visible = true;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from users where username = '" + txtUsername.Text + "'";
            cmd.ExecuteNonQuery();
            //txtUsername.Text = "";
            //display_data();

            FormsAuthentication.SignOut();
            Session.Remove("username");
            Response.Redirect("~/signup_person.aspx");
        }
    }
}