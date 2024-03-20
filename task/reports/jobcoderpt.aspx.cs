using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class task_reports_jobcoderpt : System.Web.UI.Page
{
    public string data = "",query="";
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

    //public string sss = expel.getSingleData("select assignedemps from schedule where Jobcode like");

    //string filter = "", query = "select c.id As [Sr No],s.Jobcode As[Job Code],s.sitename As [Customer Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description]," + expel.genrateemployeelist("s.Jobcode") + "  As [Employee Name] from checkinout c,schedule s where s.id=c.id And 1=1 ";
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

    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        // grdexp.DataSource = data;
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Jobcode wise report" + DateTime.Now + ".xls";
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
    protected void drdjob_SelectedIndexChanged(object sender, EventArgs e)
    {
		
	try
	{
		  cn.Open();
        
        string jobs = expel.getSingleData("select id from schedule where Jobcode like '"+drdjob.SelectedItem.Text+"'");
      //  string aa = expel.sqlDisplaytable("select e.name c.checkin,c.checkout,c.description,c.lat,c.long from checkinout c,employee e where c.eid like e.email AND c.sid=" + jobs);


        query = "select e.fname+' '+e.lname AS [Name],c.checkin As [Start Journey],c.checkout As [Stop Journey],c.description As [Description],c.lat As [Latitude] from checkinout c,employee e where c.eid like e.email AND c.sid=" + jobs;
       // query += "ANd Jobcode like '" + drdjob.SelectedValue + "'";
        //search(query);
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        cn.Close();
	}
		catch
		{
			
		}
      
      }
    //protected void btnsearch_Click(object sender, EventArgs e)
    //{
    //    cn.Open();
    //    string jobs = expel.getSingleData("select Jobcode from schedule");

    //    query = "select s.Jobcode As[Job Code],s.sitename As [Customer Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],'" + expel.genrateemployeelist(jobs) + "' As [Employee Name] from checkinout c,schedule s where s.id=c.id And 1=1 ";
    //    query += "AND checkin>='" + txtfromdate.Text + "' AND checkout<='" + txttodate.Text + "'";
    //    //search(query);
    //    SqlCommand cmd = new SqlCommand(query, cn);
    //    SqlDataReader dr = cmd.ExecuteReader();
    //    grdexp.DataSource = dr;
    //    grdexp.DataBind();
    //    cn.Close();
    //}
}