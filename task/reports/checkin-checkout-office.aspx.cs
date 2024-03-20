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

public partial class task_reports_checkin_checkout_office : System.Web.UI.Page
{
    public string data = "", query = "";
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    public void search(string q)
    {
        data = "";
        data = expel.sqlDisplaytable(q);

    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        //
    }

    protected void drdoffice_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        //query = "select e.id,e.fname+' '+e.lname AS [Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],c.lat As [Latitude],c.long As [Longitude] from checkinout c,employee e where c.eid like e.email";

        string sid = expel.getSingleData("select sid from checkinout");
      //  string data = expel.sqlDisplaytable("select e.fname+' '+e.lname AS [Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],c.lat As [Latitude],c.long As [Longitude] from checkinout c,employee e where e.fname like '" + drdoffice.SelectedItem.Text + "' and c.sid like 'No Data Found'");


        query = "select e.fname+' '+e.lname AS [Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],c.lat As [Latitude],c.long As [Longitude] from checkinout c,employee e where c.eid like '" + drdoffice.SelectedValue + "' AND c.sid like 'No Data Found' AND c.eid like e.email";
        data = expel.sqlDisplaytable(query);
      //  Response.Write("<script>alert('')</script>");
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        grdexp.Visible = false;
        cn.Close();
    
    }
    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Employee wise report" + DateTime.Now + ".xls";
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