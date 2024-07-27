using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class booking : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            //txtUsername.Text = Session["username"].ToString();


            if (Session["Museum"] != null)
            {
                txtTourName.Text = (string)Session["Museum"];
                txtPrice.Text = (string)Session["Price_Museum"];

            }
            else if (Session["Dive"] != null)
            {
                txtTourName.Text = (string)Session["Dive"];
                txtPrice.Text = (string)Session["Price_Dive"];

            }
            else if (Session["Jetpack"] != null)
            {
                txtTourName.Text = (string)Session["Jetpack"];
                txtPrice.Text = (string)Session["Price_Jetpack"];

            }
            else if (Session["Wahooo"] != null)
            {
                txtTourName.Text = (string)Session["Wahooo"];
                txtPrice.Text = (string)Session["Price_Wahooo"];

            }
            else if (Session["Karting"] != null)
            {
                txtTourName.Text = (string)Session["Karting"];
                txtPrice.Text = (string)Session["Price_Karting"];

            }
            else if (Session["Dilmun"] != null)
            {
                txtTourName.Text = (string)Session["Dilmun"];
                txtPrice.Text = (string)Session["Price_Dilmun"];

            }
            else if (Session["BabBahrain"] != null)
            {
                txtTourName.Text = (string)Session["BabBahrain"];
                txtPrice.Text = (string)Session["Price_BabBahrain"];

            }
            else if (Session["QalatAlBahrain"] != null)
            {
                txtTourName.Text = (string)Session["QalatAlBahrain"];
                txtPrice.Text = (string)Session["Price_QalatAlBahrain"];

            }
            else
            {
                txtTourName.Text = "nothing";
            }






            if (Session["username"] != null)
            {
                txtUsername.Text = Session["username"].ToString();
                //txtTourName.Text = Session["username"].ToString();
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

        }
        void clear()
        {
            txtID.Text = "";
            txtTourName.Text = "";
            ddlPackageType.Text = "";
            ddlPaymentType.Text = "";
            txtDesc.InnerText = "";
            StartDate.Value = "";
            EndDate.Value = "";
            txtPrice.Text = "";
            txtCompanyID.Text = "";
            txtGuideID.Text = "";
        }

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            DateTime dt_start = DateTime.Parse(StartDate.Value);
            DateTime dt_now = DateTime.Now;

            if (dt_start.Date >= dt_now.Date)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into tour values('" + txtTourName.Text + "','" + ddlPackageType.Text + "','" + ddlPaymentType.Text + "','"
                   + txtDesc.InnerText + "','" + StartDate.Value + "','" + EndDate.Value + "','" + txtPrice.Text + "','"
                   + txtCompanyID.Text + "','" + txtGuideID.Text + "','" + Session["username"] + "')";
                cmd.ExecuteNonQuery();
                clear();

            }
            else
            {
                clear();
                txtID.Text = "Start date is not correct";
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}