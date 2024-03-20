using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class task_company_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string site,id;

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
        try
        {
            id=Request.QueryString["id"].ToString();
        }
        catch
        {

        }

      //  string dates = expel.getSingleData("select datetime from site");
      //string frm = Convert.ToDateTime(dates).ToString("yyyy/MM/dd");

      site = expel.sqlDisplaytable("select  id,datetime As [Date Time],sitename As [Name],location,contactperson As [Contact Person],mobileno As [Mobile No],Landline As [Land line],Email from site", "add.aspx?id=", "Edit");
        //con.Open();

        //SqlCommand cmd = new SqlCommand("select * from site", con);
        //SqlDataReader dr;
        //dr = cmd.ExecuteReader();

        //site = site + "<table class='table table-bordered table-striped table-vcenter js-dataTable-full scroll_row_tabel'> <thead> <tr> <th class='text-center'>ID</th> <th>Date Time</th><th>Company Name</th> <th class='d-none d-sm-table-cell'>Location</th> <th class='d-none d-sm-table-cell'>Contact Person</th> <th class='text-center'>Contact No</th><th class='text-center'>Longitude</th><th class='text-center'>Latitude</th></tr></thead>";

        //while (dr.Read())
        //{
        //    site = site + "<tbody> <tr> <td class='text-center'> " + dr["id"].ToString() + "</td> <td class='font-w600'>" + dr["datetime"].ToString() + "</td><td class='d-none d-sm-table-cell'>" + dr["sitename"].ToString() + "</td> <td class='d-none d-sm-table-cell'>" + dr["location"].ToString() + "</td> <td class='d-none d-sm-table-cell'>" + dr["contactperson"].ToString() + "</td><td class='d-none d-sm-table-cell'>" + dr["mobileno"].ToString() + "</td><td class='d-none d-sm-table-cell'>" + dr["longitude"].ToString() + "</td><td class='d-none d-sm-table-cell'>" + dr["latitude"].ToString() + "</td><td class='text-center'> <a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='Edit'><i class='fa fa-pencil'></i></a> </td> </tr> </tbody>";
        //}

        //site = site + "</table>";

        //dr.Close();
        //con.Close();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //
    }
    protected void btnexport_Click(object sender, EventArgs e)
    {
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Customer" + DateTime.Now + ".xls";
        StringWriter strwritter = new StringWriter();
        HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentType = "application/vnd.ms-excel";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
        grdexp.GridLines = GridLines.Both;
        grdexp.HeaderStyle.Font.Bold = true;
        grdexp.RenderControl(htmltextwrtter);
        Response.Write(strwritter.ToString());
        Response.End();
        grdexp.Visible = false;
    }
}