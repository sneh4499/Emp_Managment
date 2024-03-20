using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_schedule_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string schedule = "", tods = "", frm = "", emolistsss,jobcodereport,totalcheckin,totalchekout,totalteam,totalabsunt;
    public string id1;
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

       
            ////emp's photo
            //string fname = (string)(Session["fname"]);
            //string lname = (string)(Session["lname"]);

            //con.Open();
            //SqlCommand cmd1 = new SqlCommand("select photo from employee where fname=@fname and lname=@lname", con);
            //cmd1.Parameters.AddWithValue("@fname", fname);
            //cmd1.Parameters.AddWithValue("@lname", lname);
            //SqlDataReader dr1;
            //dr1 = cmd1.ExecuteReader();
            //dr1.Read();
            //string emppic = dr1["photo"].ToString();
            //dr1.Close();
            //con.Close();
            ////end emp's photo
        try
        {    

        id1 = Request.QueryString["id"].ToString();
       
            con.Open();
           
            SqlCommand cmd = new SqlCommand("select * from schedule where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id1);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dr.Read();

            string myDateString;
            DateTime datetime;
            myDateString = dr["todate"].ToString();
            datetime = DateTime.Parse(myDateString);
            string todate = datetime.ToShortTimeString();

            myDateString = dr["fromdate"].ToString();
            datetime = DateTime.Parse(myDateString);
            string fromdate = datetime.ToShortTimeString();
            myDateString = dr["Jobcode"].ToString();
            string emps = dr["assignedemps"].ToString();
            string empname2 = expel.getSingleData("select assignemp from schedule where id="+id1);
            string empname = expel.getSingleData("select fname + '&nbsp' +lname from employee where id='" + empname2 + "'");
          
            
            //Response.Write("<script>alert("+empname+")</script>");
            try
            {
                 frm = Convert.ToDateTime(dr["fromdate"]).ToString("dd-MM-yyyy");
                tods = Convert.ToDateTime(dr["todate"]).ToString("dd-MM-yyyy");
            }
            catch
            {
               frm=dr["fromdate"].ToString();
               tods= dr["todate"].ToString();
            }
            string detailsdata = expel.sqlDisplayDetails("select location As Location,(LEN(assignedemps)- LEN(REPLACE(assignedemps, ',', '')))+1 AS [Total Employee],Jobdetail As [Additional Information] from schedule where id=" + id1);
            //schedule = schedule + "<div class='col-12'><div class='block-header block-header-default'> <h3 class='block-title'>Schedule Detail</h3> </div> <div class='block block-rounded'> <div class='block-content bg-pattern'> <div class='py-20 text-center'> <h1 class='h3 mb-5'>" + dr["workname"].ToString() + " </h1> <p class='mb-10 text-muted'><em>" + fromdate + " to " + todate + "</em> </p><p><strong>Job Code : </strong>" + dr["Jobcode"].ToString() +"</p><p>" + dr["location"].ToString() + " </p> </div> </div> </div> </div> <div class='col-md-5 col-xl-4'> <div class='js-tasks-nav d-md-block '> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Assigned Employees</h3> </div> <div class='block-content pb-20'> <ul class='nav-users push'> <li> <img class='img-avatar img-avatar-thumb' src='' alt=''>" + empname + " &nbsp &nbsp <span class='badge badge-pill badge-danger'>Team Leader</span> </li><li> <img class='img-avatar img-avatar-thumb' src='' alt=''>" + empname + " </li> </ul> </div> </div> </div> </div> <div class='col-md-7 col-xl-8'> <div class='js-tasks'><div class='block-header block-header-default'> <h3 class='block-title'>Remark</h3> </div><div class='block block-rounded mb-5 animated fadeIn block-content'><p>Site Name : " + dr["sitename"].ToString() + "</p> <p>" + dr["remark"].ToString() + "</p> </div> </div> </div>";
            schedule = schedule + "<div class='col-12'><div class='block-header block-header-default'> <h3 class='block-title'>Schedule Detail</h3></div> <div class='block block-rounded'> <div class='block-content bg-pattern'> <div class='py-20 text-center'> <h1 class='h3 mb-5'>" + dr["sitename"].ToString() + " </h1> <p>" + dr["workname"].ToString() + "</p><p><strong>Work Code : </strong>" + dr["Jobcode"].ToString() + "</p><p class='mb-10 text-muted'><em>From Date :" + Convert.ToDateTime(dr["fromdate"]).ToString("dd-MM-yyyy") + " To Date : " + Convert.ToDateTime(dr["todate"]).ToString("dd-MM-yyyy") + "</em> </p><p>" + dr["location"].ToString() + " </p> </div> </div> </div> </div> <div class='col-md-5 col-xl-4'> <div class='js-tasks-nav d-md-block '> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Assigned Employees</h3> </div> <div class='block-content pb-20'> " + expel.genrateemployeethumb(id1) + " </div> </div> </div> </div> <div class='col-md-7 col-xl-8'> <div class='js-tasks'><div class='block-header block-header-default'> <h3 class='block-title'>Description</h3> </div><div class='block block-rounded mb-5 animated fadeIn block-content'><p>" + detailsdata + "</p> </div> </div> </div>";
            dr.Close();
            con.Close();

            jobcodereport = expel.sqlDisplaytable("select e.fname+' '+e.lname AS [Name],c.checkin As [Check In],c.checkout As [Check Out],c.description As [Description],c.lat As [Latitude],c.long As [Longitude] from checkinout c,employee e where c.eid like e.email AND c.sid like '" +id1+"'");
            totalteam = expel.getSingleData("select (LEN(assignedemps)- LEN(REPLACE(assignedemps, ',', '')))+1 AS [Total Employee] from schedule where id=" + id1);
            totalcheckin = expel.getSingleData("select count(*) from checkinout c,employee e where c.eid like e.email AND c.checkin!='' AND c.sid like '" + id1+"'");
            totalchekout = expel.getSingleData("select count(*) from checkinout c,employee e where c.eid like e.email AND c.checkout!='' AND c.sid like '" + id1 + "'");

            try
            {
                totalabsunt = (int.Parse(totalteam) - int.Parse(totalcheckin)).ToString();

            }
            catch
            {
                totalabsunt = "0";
            }

             
    }
    catch
        {
            Response.Redirect("view.aspx");
        }
      
    }
}