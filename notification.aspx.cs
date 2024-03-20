using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class notification : System.Web.UI.Page
{
    public static string notification_msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string uid = "";
        if (Request.QueryString["u"] != null)
        {
            uid = Request.QueryString["u"].ToString();
           notification_msg = expel.getSingleData("select message from notification where userid like '" + uid + "' and status Not like '0'");
        //string id = expel.getSingleData("select Id from notification where userid like '" + uid + "' and status Not like '0'");
            expel.update("notification", "status", "0","1", "1 and userid like '" + uid + "' and status Not like '0'");
        }
        else
        {
         notification_msg = "No Data Found";
        }
        

    }
}