using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["username"] = null;
        Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1d);
        Response.Cookies["role"].Expires = DateTime.Now.AddDays(-1d);
        try
        {
            Response.Cookies["checkin"].Expires = DateTime.Now.AddDays(-1d);
        }
        catch
        { 
        
        }
    }
}