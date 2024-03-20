using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department_management_management : System.Web.UI.MasterPage
{
    public string name, img;
    protected void Page_Load(object sender, EventArgs e)
    {
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
       
    }
}
