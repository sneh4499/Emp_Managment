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
public partial class task_work_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string work;
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

        SqlCommand cmd = new SqlCommand("select id,jobcode,sitename,worklocation,workname,Status from work order by id desc", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        work = work + "<table class='table table-hover table-vcenter'><thead> <tr> <th class='text-center' style='width:50px;'>Sr No</th> <th>Job Code</th> <th>Customer Name</th> <th>Location</th><td>Job Name</td><th class='text-center' style='width:100px;'>Status</th></tr></thead>";
        string s = "";
        while (dr.Read())
        {

            for (int i = 0; i < dr.FieldCount; i++)
            {

                if (dr.GetName(i).ToString() == "Status")
                {

                    if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Pending")
                        s = "warning";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Ongoing" || dr[dr.GetName(i).ToString()].ToString().Trim() == "In Process" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Submitted")
                        s = "primary";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Completed")
                        s = "success";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Assigned")
                        s = "info";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Revison")
                        s = "warning";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Canceled")
                        s = "danger";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Finished")
                        s = "success";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Active" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Approved")
                        s = "success";
                    else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Inactive" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Declined")
                        s = "default";


                    //  data = data + "<td> <span class='badge badge-" + s + "'>" + dr[dr.GetName(i).ToString()].ToString() + "</span></td>";
                    //     sold = snew;
                    //   snew = s;
                }
            }

            work = work + "<tbody><tr class='table-"+s+"'><th class='text-center' scope='row'>" + dr["id"].ToString() + "</th><td>" + dr["jobcode"].ToString() + "</td><td>" + dr["sitename"].ToString() + "</td><td>" + dr["worklocation"].ToString() + "</td><td>" + dr["workname"].ToString() + "</td><td><span class='badge badge-" + s + "'>" + dr["Status"].ToString() + "</span></td><td class='text-center'><div class='btn-group'> <a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='Edit'><i class='fa fa-pencil'></i></a> <a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='View'><i class='fa fa-eye'></i></a> </div></td></tr></tbody>";
        }

        work = work + "</table>";

        //work = work + "<table class='table table-hover table-vcenter'><thead> <tr> <th class='text-center' style='width:50px;'>#</th> <th>Work Name</th> <th>Time Period</th> <th>Work priority</th><th class='text-center' style='width:100px;'>Status</th></tr></thead>";

        //while (dr.Read())
        //{
        //    work = work + "<tbody><tr><th class='text-center' scope='row'>" + dr["id"].ToString() + "</th><td>" + dr["workname"].ToString() + "</td><td>" + Convert.ToDateTime(dr["timefrom"]).ToString("dd/MMM/yyyy") + "&nbsp; to &nbsp;" + Convert.ToDateTime(dr["timeto"]).ToString("dd/MMM/yyyy") + "</td><td>" + dr["workpriority"].ToString() + "</td><td>" + dr["Status"].ToString() + "</td><td class='text-center'><div class='btn-group'> <a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='Edit'><i class='fa fa-pencil'></i></a> <a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='View'><i class='fa fa-eye'></i></a> </div></td></tr></tbody>";
        //}

        //work = work + "</table>";

        dr.Close();
        con.Close();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        //
    }
    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        grdexp.Visible = true;
        Response.Clear();
        Response.Buffer = true;
        Response.ClearContent();
        Response.ClearHeaders();
        Response.Charset = "";
        string FileName = "Job Master" + DateTime.Now + ".xls";
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