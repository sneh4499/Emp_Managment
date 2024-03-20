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
public partial class task_employee_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string emp;
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

        SqlCommand cmd = new SqlCommand("select id,photo,fname,lname,designation from employee ORDER BY fname ASC", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            emp = emp + "<div class='col-lg-3 col-md-4 col-sm-6'><div class='block block-rounded block-link-shadow text-center'><div class='block-content bg-gd-dusk'><div class='push'><img class='img-avatar img-avatar-thumb' src='" + dr["photo"].ToString() + "' alt=''> </div> <div class='pull-r-l pull-b py-10 bg-black-op-25'><div class='font-w600 mb-5 text-white'> " + dr["fname"].ToString() + " " + dr["lname"].ToString() + " </div> <div class='font-size-sm text-white-op'>" + dr["designation"].ToString() + "</div> </div> </div> <div class='block-content'> <div class='row items-push text-center'> <div class='col-6'> <a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-circle btn-alt-success mr-5 mb-5 js-tooltip-enabled' data-toggle='tooltip' title='View' data-original-title='Profile'><i class='fa fa-user'></i></a> </div> <div class='col-6'> <a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-circle btn-alt-warning mr-5 mb-5 js-tooltip-enabled' data-toggle='tooltip' title='Edit' data-original-title='Edit'><i class='fa fa-pencil'></i></a></div></div></div></div></div>";
        }
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
        string FileName = "Employee" + DateTime.Now + ".xls";
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
    protected void btnsearch_Click(object sender, EventArgs e)
    {
     
        con.Open();

        SqlCommand cmd = new SqlCommand("select id,photo,fname,lname,designation from employee  where fname like '%" + txtsearch.Text + "%' or lname like '%" + txtsearch.Text + "%' or mobileno like '%" + txtsearch.Text + "%'  ORDER BY fname ASC", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        emp = "";
        while (dr.Read())
        {
            emp = emp + "<div class='col-lg-3 col-md-4 col-sm-6'><div class='block block-rounded block-link-shadow text-center'><div class='block-content bg-gd-dusk'><div class='push'><img class='img-avatar img-avatar-thumb' src='" + dr["photo"].ToString() + "' alt=''> </div> <div class='pull-r-l pull-b py-10 bg-black-op-25'><div class='font-w600 mb-5 text-white'> " + dr["fname"].ToString() + " " + dr["lname"].ToString() + " </div> <div class='font-size-sm text-white-op'>" + dr["designation"].ToString() + "</div> </div> </div> <div class='block-content'> <div class='row items-push text-center'> <div class='col-6'> <a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-circle btn-alt-success mr-5 mb-5 js-tooltip-enabled' data-toggle='tooltip' title='View' data-original-title='Profile'><i class='fa fa-user'></i></a> </div> <div class='col-6'> <a href='add.aspx?id=" + dr["id"].ToString() + "' class='btn btn-circle btn-alt-warning mr-5 mb-5 js-tooltip-enabled' data-toggle='tooltip' title='Edit' data-original-title='Edit'><i class='fa fa-pencil'></i></a></div></div></div></div></div>";
        }
        dr.Close();
        con.Close();

       
       
    }
}