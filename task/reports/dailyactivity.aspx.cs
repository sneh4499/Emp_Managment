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
public partial class task_reports_dailyactivity : System.Web.UI.Page
{

    SqlDataAdapter dadapter;
    DataSet dset;
    public static string data = "";
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
  // public string sql3 = "select DISTINCT s.uploadby,j.uplodedby from schedule s,jcf j where s.id=j.id";
    string filter = "";
    public string query = "select s.id As [Sr No],s.sitename As [Customer Name],s.workname As [Job Name],s.Jobcode As [Work Code],c.checkin As [Check In],c.checkout As [Check Out],s.fromdate As [From Date],s.todate As [To Date],s.location As [Location],s.remark As [Remarks],s.uploadby As [Uploaded By],s.status As [Status] from schedule s,checkinout c where s.id=c.id And 1=1";

    
    //string sql2 = "select DISTINCT Inquiry_By from Inquiry";
    //string sql3 = "select DISTINCT City from Inquiry";
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
        
    }
    protected void drdpendingsite_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        query += "AND status like '" + drdpendingsite.SelectedValue + "'";
       // search(query);
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        cn.Close();
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        cn.Open();
        query += "AND fromdate>='" + txtfromdate.Text.ToString() + "' AND todate<='" + txttodate.Text.ToString() + "'";
        //search(query);

        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr = cmd.ExecuteReader();
        grdexp.DataSource = dr;
        grdexp.DataBind();
        cn.Close();

    }
    public void search(string q)
    {
        data = "";
        data = expel.sqlDisplaytable(q);
        var select = q;
        cn.Open();
        var dataAdapter = new SqlDataAdapter(select, cn);

        var commandBuilder = new SqlCommandBuilder(dataAdapter);
        var ds = new DataSet();
        dataAdapter.Fill(ds);
        grdexp.DataSource = ds.Tables[0];
        
        cn.Close();
        // grdexport.RE
    }
  
   protected void drduplodedby_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            query += "AND uploadby like '" + drduplodedby.SelectedItem + "'";
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

        protected void btnexport_Click(object sender, EventArgs e)
        {
           // grdexp.DataSource = data;
            grdexp.Visible = true;
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "dailyreport" + DateTime.Now + ".xls";
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