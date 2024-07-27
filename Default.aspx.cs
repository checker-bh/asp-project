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
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
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

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtMsg.InnerText != "")
            {

                //insert into database
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into contact values('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtMsg.InnerText + "')";
                cmd.ExecuteNonQuery();
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtMsg.InnerText = "";
                //connection close
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            else
            {

            }
        }

        protected void btnMuseum_Click(object sender, EventArgs e)
        {
            //Session.Remove("Museum");
            //Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Museum"] = lblMuseum.Text;
            Session["Price_Museum"] = lblPriceMuseum.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnDive_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            //Session.Remove("Dive");
            //Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Dive"] = lblDive.Text;
            Session["Price_Dive"] = lblPriceDive.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnJetpack_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            //Session.Remove("Jetpack");
            //Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Jetpack"] = lblJetpack.Text;
            Session["Price_Jetpack"] = lblPriceJetpack.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnWahooo_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            //Session.Remove("Wahooo");
            //Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Wahooo"] = lblWahooo.Text;
            Session["Price_Wahooo"] = lblPriceWahooo.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnKarting_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            //Session.Remove("Karting");
            //Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Karting"] = lblKarting.Text;
            Session["Price_Karting"] = lblPriceKarting.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnDilmun_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            //Session.Remove("Dilmun");
            //Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["Dilmun"] = lblDilmun.Text;
            Session["Price_Dilmun"] = lblPriceDilmun.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnBabBahrain_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            //Session.Remove("BabBahrain");
            //Session.Remove("Price_BabBahrain");
            Session.Remove("QalatAlBahrain");
            Session.Remove("Price_QalatAlBahrain");

            Session["BabBahrain"] = lblBabBahrain.Text;
            Session["Price_BabBahrain"] = lblPriceBabBahrain.Text;
            Response.Redirect("~/booking.aspx");
        }
        protected void btnQalatAlBahrain_Click(object sender, EventArgs e)
        {
            Session.Remove("Museum");
            Session.Remove("Price_Museum");
            Session.Remove("Dive");
            Session.Remove("Price_Dive");
            Session.Remove("Jetpack");
            Session.Remove("Price_Jetpack");
            Session.Remove("Wahooo");
            Session.Remove("Price_Wahooo");
            Session.Remove("Karting");
            Session.Remove("Price_Karting");
            Session.Remove("Dilmun");
            Session.Remove("Price_Dilmun");
            Session.Remove("BabBahrain");
            Session.Remove("Price_BabBahrain");
            //Session.Remove("QalatAlBahrain");
            //Session.Remove("Price_QalatAlBahrain");

            Session["QalatAlBahrain"] = lblQalatAlBahrain.Text;
            Session["Price_QalatAlBahrain"] = lblPriceQalatAlBahrain.Text;
            Response.Redirect("~/booking.aspx");
        }
    }
}