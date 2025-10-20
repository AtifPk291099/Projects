using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class RemoveAC : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select * from Student Where S_Uid='"+TextBox1.Text+"'",con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox2.Text=dr[0].ToString()+" "+dr[2].ToString();
            TextBox3.Text = dr[5].ToString();
            TextBox4.Text = dr[4].ToString();
            Button2.Visible = false;
            TextBox1.Enabled = false;
            Panel1.Visible = true;
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Invalid Student ID');", true);
            Panel1.Visible = false;
        }
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Delete From Student where S_Username='"+TextBox1.Text+"'",con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Student Removed Successfully');", true);
        Panel1.Visible = false;
        TextBox1.Text = "";
        TextBox1.Enabled = true;
        Button2.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("RemoveAC.aspx");
    }
}