using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select Pass From Admin Where ID='"+txtusername.Text+"'",con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            if (txtpassword.Text == dr[0].ToString())
            {
                Session["Type"] = "Admin";
                Response.Redirect("AdminP.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Invalid Password');", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Invalid User ID');", true);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}