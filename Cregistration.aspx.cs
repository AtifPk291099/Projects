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

public partial class Cregistration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {
        int s=0;
        try
        {   
            SqlDataAdapter da = new SqlDataAdapter("Select max(c_id) from company", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            s = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            s++;
            txtuid.Text = Convert.ToString(s);
        }
        catch (InvalidCastException ex)
        {
            txtuid.Text = Convert.ToString(s);
        }
    
    }
    protected void Post_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert into COMPANY values('"+txtcname.Text+"',"+ Convert.ToInt32(txtestablished.Text)+",'"+txtemail.Text+"','"+txtcontact.Text+"','"+txthrname.Text+"',"+Convert.ToInt32(txtuid.Text)+",'"+txtuname.Text+"','"+txtpassword.Text+"','"+DateTime.Now.ToString()+"')",con);
        cmd.ExecuteNonQuery();
        con.Close();
        String alertmsg = "Thank You for Registering";
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
       
        Response.Redirect("Clogin.aspx");
    }
}
