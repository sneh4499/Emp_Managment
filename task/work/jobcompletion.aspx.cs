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

public partial class task_work_jobcompletion : System.Web.UI.Page
{
  public  string imgmom, imgfeedback, imgsafety,data="",data1="";


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
        fpmom.Attributes["onchange"] = "UploadFile(this)";
        fpfeedback.Attributes["onchange"] = "UploadFile(this)";
        fpsafety.Attributes["onchange"] = "UploadFile(this)";

        data1 = expel.sqlDisplaytable("select s.id as [Schedual],w.jobcode As [Job Code],w.workname AS [Work Name],w.sitename As [Customer Name],w.worklocation As [Location],w.workpriority As [Work Priority] from work w,schedule s where s.Jobcode like w.jobcode", "/task/jcf/jifp.aspx?sid=", "Generate Job Intimation Form");
        data = expel.sqlDisplaytable("select Jobcode As [Job Code],status from schedule where status like 'Completed'", "/task/jcf/jcfp.aspx?Jobcode=", "Generate Job Complition");
       
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string Document_Path = Server.MapPath("~/data/" + Path.GetFileName(fpmom.FileName));
        fpmom.SaveAs(Document_Path);

        imgmom = "/data/" + Path.GetFileName(fpmom.FileName);

        string Document_Path1 = Server.MapPath("~/data/" + Path.GetFileName(fpfeedback.FileName));
        fpfeedback.SaveAs(Document_Path1);

        imgfeedback = "/data/" + Path.GetFileName(fpfeedback.FileName);


        string Document_Path2 = Server.MapPath("~/data/" + Path.GetFileName(fpsafety.FileName));
        fpsafety.SaveAs(Document_Path2);

        imgsafety = "/data/" + Path.GetFileName(fpsafety.FileName);


        expel.insert("jobcomplition",drdjobcode.SelectedItem.Text,imgmom,imgfeedback,imgsafety);

        string sid = expel.getSingleData("select id from schedule where Jobcode like '" + drdjobcode.SelectedItem + "'");
		 string workid = expel.getSingleData("select id from work where Jobcode like '" + drdjobcode.SelectedItem + "'");

       // Response.Write("<script>alert("+sid+")</script>");
        expel.update("schedule", "status", "Completed", "id", sid);
		   expel.update("work", "Status", "Completed", "id", workid);

       // Response.Write("<script>alert('Job Completed Successfully')</script>");


    }



  
}