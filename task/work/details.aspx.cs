using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_work_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string work, display, imgsss, safety="",feedback="",mom="";
    string prio;
    string per;
    string color;
    public string id1,data="",jc,fp="";
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
    public string ispdf(string path, ref string download)
    {
        string finalpath = "", ext = "";
        //    Response.Write("<script>alert('path: " + path + "')</script>");
        if (path.Length > 1)
            ext = path.Substring(path.IndexOf("."));
        else
            ext = "0";
        //  Response.Write("<script>alert('path: "+path+"ext : " + ext + "')</script>");

        if (ext == ".jpeg" || ext == ".png" || ext == ".jpg" || ext == ".gif")
        {
            finalpath = path;
            download = path;
        }
        else if (path == "0")
        {
            finalpath = "/imagenotavailable.png";
            download = "#";
        }
        else
        {
            finalpath = "/docimg.png";
            download = path;
        }

        return finalpath;

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            con.Open();
            id1 = Request.QueryString["id"].ToString();
            SqlCommand cmd = new SqlCommand("select * from work where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id1);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();

            string priority = dr["workpriority"].ToString();
            if (priority == "Urgent")
            {
                prio = "Urgent";
                per = "100%";
                color = "#ff0000";

            }
            else if (priority == "High")
            {
                prio = "High";
                per = "75%";
                color = "#ff6600";

            }
            else if (priority == "Medium")
            {
                prio = "Medium";
                per = "50%";
                color = "#ffff00";

            }
            else if (priority == "Low")
            {
                prio = "Low";
                per = "25%";
                color = "#c0392b";

            }
            string images = dr["files"].ToString();
            string dimages = "";
            images = ispdf(images, ref dimages);
             jc = expel.getSingleData("select jobcode from work where id="+id1);


             work = work + "<div class='col-12'> <div class='block block-rounded'> <div class='block-content bg-pattern' style='background-image:url('../../assets/media/various/bg-pattern-inverse.png');'> <div class='py-20 text-center'><h1 class='h3 mb-5'>" + dr["sitename"].ToString() + " </h1><p > " + dr["workname"].ToString() + " </p> <p><strong>Job Code : </strong>" + dr["jobcode"].ToString() + "</p><p class='mb-10 text-muted'> <em>From Date :" + Convert.ToDateTime(dr["timefrom"]).ToString("dd/MMM/yyyy") + " To Date : " + Convert.ToDateTime(dr["timeto"]).ToString("dd/MMM/yyyy") + "</em> </p> <p>Job Location: " + dr["worklocation"].ToString() + " </p> </div> </div> </div> </div> <div class='col-md-5 col-xl-3'> <div class='js-tasks-nav d-none d-md-block '> <div class='block block-rounded'> </li> </ul> </div> </div> </div> </div> <div class='col-md-12 col-xl-9'> <div class='js-tasks'> <div class='block-header block-header-default'><h3 class='block-title'>Description</h3></div> <div class='block block-rounded mb-5 animated fadeIn block-content'><p>" + expel.sqlDisplayDetails("select reference as[Reference],description from work where id=" + id1) + "</p><p> </p> </div> <div class='block-header block-header-default mt-20'><h3 class='block-title'>Priority Status</h3></div><div class='block block-rounded mb-5 animated fadeIn block-content'> <div class='progress push'> <div class='progress-bar' role='progressbar' style='width:" + per + ";background-color:" + color + "' aria-valuenow='30' aria-valuemin='0' aria-valuemax='100'> <span class='progress-bar-label'>" + prio + "</span> </div> </div> </div> </div> </div>";


            dr.Close();
            con.Close();
            string momlink = expel.getSingleData("select mom from jobcomplition where jobcode like '" + jc + "'");
            if (momlink != "No Data Found")
                mom = "<a href='" + momlink + "' class='btn btn-warning'>Mom</a>";
            else
                mom = "";
            string safetylink= expel.getSingleData("select safety from jobcomplition where jobcode like '" + jc + "'");
            if (safetylink != "No Data Found")
            {
                safety = "<a href='" + safetylink + "' class='btn btn-danger'>Safety</a>";
            }
            else
                safety = "";
          
          string feedbacklink = expel.getSingleData("select feedback from jobcomplition where jobcode like '" + jc + "'");
          if (feedbacklink != "No Data Found")
          {
              feedback = "<a href='" + feedbacklink + "' class='btn btn-info'>Feedback</a>";
          }
          else
              feedback = "";
        }
        catch
        {
            Response.Redirect("view.aspx");
        }
    }
}