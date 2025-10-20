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

public partial class addvacancy : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {

        txtcompanyid.Text = Convert.ToString(Session["c_id"]);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into vacancy values('" + Convert.ToInt32(txtcompanyid.Text) + "','" + txtjobprofile.Text + "','" + txtsal.Text + "','" + txtdetails.Text + "','" + txtbond.Text + "','" + Convert.ToString(DateTime.Now) + "','" + Convert.ToString(Session["Company"]) +"','"+TextBox1.Text+"')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        String alertmsg = "Thank You for Posting";
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
    }
}
