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

public partial class Clogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from company where c_uname='"+txtusername.Text+"' and c_pass='"+txtpassword.Text+"'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        if (ds2.Tables[0].Rows.Count != 0)
        {
            Session["c_id"]=ds2.Tables[0].Rows[0][5];
            Session["Company"] = ds2.Tables[0].Rows[0][0];
            Session["Type"] = "Company";
            SqlCommand cmd = new SqlCommand("update company set c_seen='" + DateTime.Now.ToString() + "' where c_uname='" + txtusername + "'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("CompHome.aspx");
        }
        else
        {
            String alertmsg = "Enter valid username / Password";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
