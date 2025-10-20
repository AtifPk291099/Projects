using System;
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
using System.Data;
using System.Data.SqlClient;
using System.Threading;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        int s;
        SqlDataAdapter da = new SqlDataAdapter("Select max(s_uid) from student", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        try
        {
            s = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            s++;
        }
        catch (InvalidCastException ex)
        { s = 0; }
        txtuid.Text = Convert.ToString(s);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        if (txtfname.Text != "")
        {
            if (txtmname.Text != "")
            {
                if (txtlname.Text != "")
                {
                    if (txtemail.Text != "")
                    {
                        if (txtcontact.Text != "")
                        {
                            if (txtusername.Text != "")
                            {
                                if (txtpassword.Text != "")
                                {

                                    if (lblusername.Text == "Username Available")
                                    {

                                        string image = FileUpload2.FileName;
                                        string path = Server.MapPath("~\\images\\");
                                        FileUpload1.SaveAs(path + image);
                                        

                                        con.Open();
                                        string insert = "Insert into student values('" + txtfname.Text + "', '" + txtmname.Text + "', '" + txtlname.Text + "', '" + DropDownList1.SelectedItem.Text + "', '" + txtemail.Text + "', '" + txtcontact.Text + "', '" + txtaddress.Text + "', '" + Convert.ToInt32(txtuid.Text) + "', '" + txtdob.Text + "', '" + txtage.Text + "', '" + txtschool.Text + "', '" + txtsyearofpass.Text + "', '" + txtsuniversity.Text + "', '" + txtsaggregate.Text + "', '" + txthsc.Text + "', '" + txthuniversity.Text + "', '" + txthyearofpass.Text + "', '" + txthaggregate.Text + "', '" + txtcoll.Text + "', '" + txtcuniversity.Text + "', '" + txtcyearofpass.Text + "', '" + txtcaggregate.Text + "', '" + txtextracirr.Text + "', '" + txtotherqualification.Text + "', '" + txtusername.Text + "', '" + txtpassword.Text + "', '" + ddldepartment.Text + "', '" + DateTime.Now.ToString() + "', '" + path + image + "')";
                                        SqlCommand cmd = new SqlCommand(insert, con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        String alertmsg = "Thank You for Registering";
                                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
                                        
                                    }
                                    else
                                    {
                                        String alertmsg = "Enter valid username";
                                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
                                    }
                                }
                                else
                                { Label1.Visible = true; }
                            }
                            else
                            { Label1.Visible = true; }
                        }
                        else
                        { Label1.Visible = true; }
                    }
                    else
                    { Label1.Visible = true; }
                }
                else
                { Label1.Visible = true; }
            }
            else
            { Label1.Visible = true; }
        }
        else
        { Label1.Visible = true; }
    }
    protected void txtusername_TextChanged(object sender, EventArgs e)
    {

        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from student where s_username='" + txtusername.Text + "'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        
            if (ds2.Tables[0].Rows.Count == 0)
        {
            lblusername.Text = "Username Available";
        }
        else
        {
            lblusername.Text = "Username Not Available";
        }
            
        if (lblusername.Text == "Username Available")
            {
                txtpassword.Enabled = true;
            }
            else if (lblusername.Text == "Username Not Available")
            {
                txtpassword.Enabled = false;
            }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        String image = FileUpload1.FileName;
        String path = Server.MapPath("~\\images\\");
        FileUpload1.SaveAs(path + image);
        Image1.ImageUrl = "images\\" + image;
    }
}
