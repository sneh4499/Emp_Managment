using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_jcf_jcfall : System.Web.UI.Page
{
    public string data = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        data = expel.sqlDisplaytable("select Jobcode,status from schedule where status like 'Completed' ", "jcfp.aspx?Jobcode=", "Generate Job Complition");

    }
}