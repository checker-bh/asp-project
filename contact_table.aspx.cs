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
    public partial class contact_table : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
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
                    //lblSession.Text = "Welcome, " + Session["username"];
                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display_data();
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Contact";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdViewContact.DataSource = dt;
            grdViewContact.DataBind();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                display_data();
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from contact where contact_name = '" + txtSearch.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                grdViewContact.DataSource = dt;
                grdViewContact.DataBind();
            }
        }

    }
}