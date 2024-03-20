using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class get : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
    public string[] arr = new string[100];
    public string longitude;
   public string latitude;
   public string user;
   public string deviceid;

  
  
    protected void Page_Load(object sender, EventArgs e)
    {

        longitude = Request.QueryString["long"];
        latitude = Request.QueryString["lat"];
        user = Request.QueryString["user"];
        deviceid = Request.QueryString["did"];
        if (user.IndexOf("@") > 0)
        {
            expel.insert("location", user, latitude, longitude, deviceid, DateTime.Now.ToString());
        }
    }
}