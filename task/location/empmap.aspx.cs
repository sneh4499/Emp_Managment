using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class task_location_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public static string x = "";
    public static string locationheader = "";
    public static string locationdetials = "";

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
        SqlCommand cmd = new SqlCommand("select DISTINCT eid,LAST_VALUE(lat) OVER (PARTITION BY eid ORDER BY id) as lat,LAST_VALUE(long) OVER (PARTITION BY eid ORDER BY id) as long from location",con);
       con.Open();
        SqlDataReader dr ;
        dr= cmd.ExecuteReader();
        int i = 0;
        while (dr.Read())
        {
            locationheader = locationheader + "var emp"+i.ToString()+" = { lat: " + dr["lat"].ToString() + ", lng:" + dr["long"].ToString() + " };";
            locationdetials = locationdetials + "var marker = new google.maps.Marker({ position: emp"+i.ToString()+", map: map, title: '"+dr["eid"].ToString()+"' });";
            i++;
        }
        con.Close();
     //   locationheader = expel.genratemap("select DISTINCT eid,LAST_VALUE(lat) OVER (PARTITION BY eid ORDER BY id) as lat,LAST_VALUE(long) OVER (PARTITION BY eid ORDER BY id) as long,date from location where id=(select max(id) from location where eid like eid group by eid)");
        locationheader = expel.genratemap("select DISTINCT eid,LAST_VALUE(lat) OVER (PARTITION BY eid ORDER BY id) as lat,LAST_VALUE(long) OVER (PARTITION BY eid ORDER BY id) as long,date from location");
       }
}