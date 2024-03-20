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

public partial class task_reports_empreport : System.Web.UI.Page
{
    public string data = "";
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    string filter = "", query = "select c.id As [Sr No],s.Jobcode As[Work Code],s.sitename As [Customer Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],c.lat As [Latitude],c.long As [Longitude],s.fromdate As [From Date],s.todate As [To date],c.eid As [Employee Id] from checkinout c,schedule s where s.id=c.id And 1=1 ";
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
    public void search(string q)
    {
        data = "";
        data = expel.sqlDisplaytable(q);
      
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void drdemployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        query += "ANd eid like '" + drdemployee.SelectedValue + "'";
        //search(query);
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        cn.Close();
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        cn.Open();
        query += "AND checkin>='" + txtfromdate.Text + "' AND checkout<='" + txttodate.Text + "'";
        //search(query);
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        cn.Close();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //
    }
    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        // grdexp.DataSource = data;
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Employee report" + DateTime.Now + ".xls";
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