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

public partial class task_schedule_pending : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string schedule;

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

        SqlCommand cmd = new SqlCommand("select * from schedule where status like 'Pending'", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        schedule = schedule + "<table class='table table-hover table-vcenter'><thead> <tr> <th class='text-center' style='width:50px;'>Sr No</th><th>Job Code</th> <th>Customer Name</th><th>Location</th><th>Work Name</th> <th>SCHEDULE DATE</th><th>Status</th><th class='text-center' style='width:100px;'>Actions</th></tr></thead>";



        string myDateString;
        DateTime datetime;

        while (dr.Read())
        {
            string todate = "", fromdate = "";
            try
            {
                myDateString = dr["todate"].ToString();
                datetime = DateTime.Parse(myDateString);
                todate = datetime.ToString();

                myDateString = dr["fromdate"].ToString();
                datetime = DateTime.Parse(myDateString);
                fromdate = datetime.ToString();
            }
            catch
            {
                todate = "";
                fromdate = "";
            }

            //<a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='Edit'><i class='fa fa-pencil'></i></a>
            schedule = schedule + "<tbody><tr><th class='text-center' scope='row'>" + dr["id"].ToString() + "</th><td>" + dr["Jobcode"].ToString() + "</td><td>" + dr["sitename"].ToString() + "</td><td>" + dr["location"].ToString() + "</td><td>" + dr["workname"].ToString() + "</td><td>" + fromdate + "&nbsp; to &nbsp;" + todate + "</td><td>" + dr["status"].ToString() + "</td><td class='text-center'><div class='btn-group'><a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='View'><i class='fa fa-eye'></i></a></div></td></tr></tbody>";
        }

        schedule = schedule + "</table>";

        dr.Close();
        con.Close();
    }
    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Schedule" + DateTime.Now + ".xls";
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