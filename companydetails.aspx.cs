using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class companydetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtsal1.Text == "" && txtsal2.Text == "" && txtprofile.Text == "")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select  c_id, c_profile, c_salary, c_details, c_bond, c_date, c_name, c_email from vacancy", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        if (txtsal1.Text == "" && txtsal2.Text == "")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select  c_id, c_profile, c_salary, c_details, c_bond, c_date, c_name, c_email from vacancy where c_profile like '%" + txtprofile.Text + "%' ", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        else if (txtprofile.Text=="")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select  c_id, c_profile, c_salary, c_details, c_bond, c_date, c_name, c_email from vacancy where c_salary between " + txtsal1.Text + " And " + txtsal2.Text + "", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        else if (txtsal1.Text != "" && txtsal2.Text != "" && txtprofile.Text != "")
        {
            string str = "Select c_id, c_profile, c_salary, c_details, c_bond, c_date, c_name, c_email from vacancy where c_profile like '%" + txtprofile.Text + "%' and c_salary between '" + txtsal1.Text + "' And '" + txtsal2.Text + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(str, con);
            DataSet ds2 = new DataSet();
                da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
    }
}
