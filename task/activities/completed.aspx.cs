using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_activities_completed : System.Web.UI.Page
{
    public string data = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        data = expel.sqlDisplaytable("select id  As [Sr No],jobcode As [Work Code],sitename As [Customer Name],location As [Location],fromdate As [From Date],todate As [To Date],status from schedule where status like 'Completed'", "/task/schedule/details.aspx?id=", "View");
    }
}