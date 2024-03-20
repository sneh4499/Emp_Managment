using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_activities_pending : System.Web.UI.Page
{
    public string data = "";
    protected void Page_Load(object sender, EventArgs e)
    {
		 data = expel.sqlDisplaytable("select id  As [Sr No],jobcode As [Work Code],sitename As [Customer Name],worklocation As [Location],status from work where status like 'Pending'", "/task/work/details.aspx?id=", "View");
       // data = expel.sqlDisplaytable("select id  As [Sr No],jobcode As [Job Code],sitename As [Customer Name],location As [Location],fromdate As [From Date],todate As [To Date],status from schedule where status like 'Pending'", "/task/schedule/details.aspx?id=", "View");
    }
}