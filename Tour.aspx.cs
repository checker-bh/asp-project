using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAHRAIN_TOURS
{
    public partial class Tour1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BAHRAIN_TOURS.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                txtUsername.Text = Session["username"].ToString();
                //txtTourName.Text = Session["username"].ToString();
            }
            else
            {
                Response.Redirect("~/login_person.aspx");
            }



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
        protected void btnInsert_Click(object sender, EventArgs e)
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
                display_data();
            }
            else
            {
                clear();
                txtID.Text = "Start date is not correct";
            }


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tour where tour_name = '" + txtTourName.Text + "'";
            cmd.ExecuteNonQuery();
            clear();
            display_data();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            DateTime dt_start = DateTime.Parse(StartDate.Value);
            DateTime dt_now = DateTime.Now;

            if (dt_start.Date >= dt_now.Date)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tour set tour_name='" + txtTourName.Text +
                    "',packageType='" + ddlPackageType.Text +
                    "',paymentType='" + ddlPaymentType.Text + "',decription='" + txtDesc.InnerText +
                    "',start_date='" + StartDate.Value + "',end_date='" + EndDate.Value +
                    "',price='" + txtPrice.Text + "',company_id='" + txtCompanyID.Text + "',guide_id='" +
                    txtGuideID.Text + "',username='" + Session["username"] + "' where id=" + Convert.ToInt32(txtID.Text) + "";
                cmd.ExecuteNonQuery();
                clear();
                display_data();
            }
            else
            {
                clear();
                txtID.Text = "Start date is not correct";
            }

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            display_data();
        }
        public void display_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tour";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grviewTour.DataSource = dt;
            grviewTour.DataBind();
        }

        protected void grviewTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = grviewTour.SelectedRow.Cells[1].Text;
            txtTourName.Text = grviewTour.SelectedRow.Cells[2].Text;
            ddlPackageType.Text = grviewTour.SelectedRow.Cells[3].Text;
            ddlPaymentType.Text = grviewTour.SelectedRow.Cells[4].Text;
            txtDesc.InnerText = grviewTour.SelectedRow.Cells[5].Text;
            StartDate.Value = grviewTour.SelectedRow.Cells[6].Text;
            EndDate.Value = grviewTour.SelectedRow.Cells[7].Text;
            txtPrice.Text = grviewTour.SelectedRow.Cells[8].Text;
            txtCompanyID.Text = grviewTour.SelectedRow.Cells[9].Text;
            txtGuideID.Text = grviewTour.SelectedRow.Cells[10].Text;
            txtUsername.Text = grviewTour.SelectedRow.Cells[11].Text;
        }
    }
}