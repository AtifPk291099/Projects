using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;

public partial class StudentDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select distinct s_dept from student", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            int rows = ds2.Tables[0].Rows.Count;
            if (rows != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    ddldept.Items.Add(Convert.ToString(ds2.Tables[0].Rows[i][0]));
                }
            }
            else
            {
                ddldept.Items.Add("No Students Available");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ssc=txthsc.Text, hsc=txthsc.Text, coll=txtcoll.Text,dept=ddldept.Text;
        if (ssc == "")
        {
            ssc = "0";
        }
        if (hsc == "")
        {
            hsc = "0";
        }
        if (coll == "")
        {
            coll = "0";
        }
        string str = "Select s_fname,s_lname,s_age,s_gender,s_email,s_contact,s_seen,s_resume from student where s_saggregate >= '" + txtssc.Text + "' and s_caggregate >= '" + txthsc.Text + "' and s_c2aggregate >= '" + txtcoll.Text + "' and s_dept='" + dept + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(str, con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        GridView1.DataSource = ds2;
        GridView1.DataBind();

        Panel1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("atifkhan0679@gmail.com");
            mail.To.Add(TextBox1.Text);
            mail.Subject = "Mail From Campus Recruit System";
            mail.Body = TextBox2.Text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("atifkhan0679@gmail.com", "9326132414");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Mail Sent Succesfully');", true);
        }
        catch (Exception ep)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Mail Not Sent');", true);
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "click")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            Response.Clear();
            Response.ContentType = "application/octect-stream";
            Response.AppendHeader("content-disposition", "filename = " + i);
            Response.TransmitFile(i);
            Response.End();


        }
    }
}
