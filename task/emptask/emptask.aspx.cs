using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_emptask_emptask : System.Web.UI.Page
{
    public static string data = "";

    protected void Page_PreInit(object sender, EventArgs e)
    {
        try
        {
            String useMasterPage = Request.Cookies["role"].Value.ToString();
            if (useMasterPage != "")
                MasterPageFile = "~/department/" + useMasterPage + "/" + useMasterPage + ".Master";
            else
            {

                Response.Redirect("~/index.aspx");
            }
        }
        catch
        {
            Response.Redirect("~/index.aspx");

        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string employee=expel.getSingleData("select id from employee where email like '"+Request.Cookies["email"].Value.ToString()+"'");
       
		
		 data = expel.sqlDisplaytable("select id,sitename,workname,fromdate,todate,status from schedule where assignedemps like '" + employee + ",%' or assignedemps like '%," + employee + ",%' or assignedemps like '%," + employee + "' or assignedemps like '" + employee + "'");
		
		//data = expel.sqlDisplaytable("select id,sitename,workname,todate,fromdate,status from schedule where assignedemps like '%" + employee + "%'");
    }
}