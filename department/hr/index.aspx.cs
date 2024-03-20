using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department_hr_index : System.Web.UI.Page
{
    public string totalemp = "",data="";
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
        totalemp = expel.getSingleData("select count(*) from employee");
        data = expel.sqlDisplaytable("select id,fname+' '+lname,designation,email,mobileno from employee", "/task/employee/details.aspx?id=", "View Detail");

    }
}