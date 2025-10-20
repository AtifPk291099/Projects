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
using Check;

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        #region System Generated . . .
        Class1 c = new Class1();
        bool c1 = c.checkLoad("S179", con);
        if (!c1)
        {
            Response.Redirect("Login.aspx");
        }
        #endregion
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select s_username,s_password from student where s_username='" + txtusername.Text + "' and s_password='"+txtpassword.Text+"'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        if (ds2.Tables[0].Rows.Count != 0)
        {
            Session["name"]=ds2.Tables[0].Rows[0][0];
            Session["Type"] = "Student";

            SqlCommand cmd = new SqlCommand("update student set s_seen='" + DateTime.Now.ToString() + "' where s_username='" + txtusername + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("StudHome.aspx");
        }
        else
        {
            String alertmsg = "Enter valid username / Password";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
        }
    }
}
