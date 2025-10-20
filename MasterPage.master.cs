using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Convert.ToString(Session["Type"]) == "Company")
        {
            Button1.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = true;
            HyperLink1.Visible = true;
            HyperLink2.Visible = true;
            HyperLink3.Visible = false;
            HyperLink4.Visible = false;
            HyperLink5.Visible = false;
        }
        else if (Convert.ToString(Session["Type"]) == "Student")
        {
            Button1.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = true;
            HyperLink1.Visible = false;
            HyperLink2.Visible = false;
            HyperLink3.Visible = true;
            HyperLink4.Visible = true;
            HyperLink5.Visible = false;
        }
        else if (Convert.ToString(Session["Type"]) == "Admin")
        {
            Button1.Visible = true;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = true;
            HyperLink1.Visible = true;
            HyperLink2.Visible = false;
            HyperLink3.Visible = true;
            HyperLink4.Visible = true;
            HyperLink5.Visible = true;
        }
        else
        {
            Button1.Visible = false;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = false;
            HyperLink1.Visible = false;
            HyperLink2.Visible = false;
            HyperLink3.Visible = false;
            HyperLink4.Visible = false;
            HyperLink5.Visible = false;
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("index.aspx");
    }
}
