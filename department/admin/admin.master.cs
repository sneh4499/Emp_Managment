using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department_admin_admin : System.Web.UI.MasterPage
{
    public string username = "", name,img;

  
    protected void Page_Load(object sender, EventArgs e)
    {


        //username = (string)(Session["username"]);

        try
        {
            name = expel.getSingleData("select username from login where email like '" + Request.Cookies["email"].Value.ToString() + "'");
            img = expel.getSingleData("select photo from login where email like '" + Request.Cookies["email"].Value.ToString() + "'");
			
			 if (img == "0")
            {
                img = "../../assets/media/avatars/avatar15.jpg";

            }
        }
        catch
        {
            img = "../../assets/media/avatars/avatar15.jpg";
            name = "Name Not Found";
        }
       
        //if (username != "Admin")
        //{
        //    Response.Redirect("~/index.aspx");
        //}
        //else
        //{

        //}




        
    }
}
