using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_department_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string dept;

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

        con.Open();

        SqlCommand cmd = new SqlCommand("select distinct parentdept,deptname from department", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

      
        while (dr.Read())
        {
            dept = dept + "<div class='row'> <div class='col-md-4'><div class='block-content block-content-full'> <div class='js-nestable-connected-simple dd'> <ol class='dd-list'> <li class='dd-item' data-id='1'> <div class='dd-handle'>" + dr["parentdept"].ToString() + "</div> <ol class='dd-list'> <li class='dd-item' data-id='2'> <div class='dd-handle'>" + dr["deptname"].ToString() + "</div> </li> </ol> </li> </ol> </div> </div></div></div>";
        }

       
        dr.Close();
        con.Close();
        
    }
}