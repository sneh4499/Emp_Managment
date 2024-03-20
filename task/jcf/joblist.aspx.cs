using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_jcf_joblist : System.Web.UI.Page
{
    public string data = "";
    protected void Page_Load(object sender, EventArgs e)
{
    string uid = expel.getSingleData("select id from employee where email like '"+Request.Cookies["email"].Value.ToString()+"'");
    //Response.Write("<script>alert('" + uid + "')</script>");
    data = expel.sqlDisplaytable("select Jobcode from schedule where teamleader like '" + uid + "' AND status like 'In Process'", "jcf.aspx?jobcode=", "Fill UP");

    }
}