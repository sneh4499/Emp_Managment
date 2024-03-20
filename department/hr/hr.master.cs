using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department_hr_hr : System.Web.UI.MasterPage
{
    public string username, name, img, id;
    protected void Page_Load(object sender, EventArgs e)
    {


        //username = (string)(Session["username"]);
        name = expel.getSingleData("select username from login where email like '" + Request.Cookies["email"].Value.ToString() + "'");
        try
        {
            id = expel.getSingleData("select id from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'"); ;

            img = expel.getSingleData("select photo from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'");
			
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
    }
}
