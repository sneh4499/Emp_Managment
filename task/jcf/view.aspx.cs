using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_jcf_view : System.Web.UI.Page
{
    public string data = "",data1;
    protected void Page_Load(object sender, EventArgs e)
    {
       // data = expel.sqlDisplaytable("select * from jcf","jcfp.aspx?Id=","Print");

        data = expel.sqlDisplaytable("select jobcode,workname,sitename,worklocation,workpriority from work", "jifp.aspx?jobcode=", "Generate Job Intemation Form");
    }
}