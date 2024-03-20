using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_location_employee : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public static string map = "";
    public static string emp = "", emp1 = "", teamleader = "";

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
        if(!IsPostBack)
        {

         //   map = expel.genratemap("select * from location");

        }

      



       
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        map = expel.genratemap("select * from location where eid like '"+DropDownList1.SelectedValue+"'");
        drddate.Items.Clear();
		        drddate.Items.Insert(0,ListItem.FromString("Select here.."));

    }
    protected void drddate_SelectedIndexChanged(object sender, EventArgs e)
    {
        map = expel.genratemap("select * from location where eid like '%" + DropDownList1.SelectedValue + "%' and FORMAT(CAST(date AS DATE), 'dd/MM/yyyy') like '" + drddate.SelectedValue + "'");
      }
}