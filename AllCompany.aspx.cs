using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AllCompany : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3RR24A39\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");
        SqlDataAdapter da2 = new SqlDataAdapter("Select distinct c_name,c_hr,c_email,c_contact,c_seen from company", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        GridView1.DataSource=ds2;
        GridView1.DataBind();
    }
}