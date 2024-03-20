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
using System.Text;
public partial class task_schedule_view : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string schedule, id, emolistsss, export, data;

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
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

      

       

        dt = new DataTable();
        DataColumn dc1 = new DataColumn("sitename");
        DataColumn dc2 = new DataColumn("workname");
        DataColumn dc3 = new DataColumn("todate");
        DataColumn dc4 = new DataColumn("fromdate");
        DataColumn dc5 = new DataColumn("location");
        DataColumn dc6 = new DataColumn("assignedemps");
        DataColumn dc7 = new DataColumn("teamleader");
        DataColumn dc8 = new DataColumn("remark");
        DataColumn dc9 = new DataColumn("uploadby");
        DataColumn dc10 = new DataColumn("status");
        DataColumn dc11 = new DataColumn("Jobcode");
       
        dt.Columns.Add(dc1);
        dt.Columns.Add(dc2);
        dt.Columns.Add(dc3);
        dt.Columns.Add(dc4);
        dt.Columns.Add(dc5);
        dt.Columns.Add(dc6);
        dt.Columns.Add(dc7);
        dt.Columns.Add(dc8);
        dt.Columns.Add(dc9);
        dt.Columns.Add(dc10);
        dt.Columns.Add(dc11);
       
           
        DataRow dr1 = dt.NewRow();
        grdexp.DataSource = dt;
        grdexp.DataBind();
        //emolistsss = expel.genrateemployeethumb("SELECT * FROM [schedule]");

        //Response.Write("<script>alert(" + emolistsss + ")</script>");

        con.Open();

        SqlCommand cmd = new SqlCommand("select * from schedule order by id desc", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();





        schedule = schedule + "<table class='table table-hover table-vcenter'><thead> <tr> <th class='text-center' style='width:50px;'>Sr No</th><th>Job Code</th> <th>Name</th><th>Location</th><th>Job Name</th> <th >SCHEDULE DATE</th><th class='text-center' style='width:50px;'>Status</th><th >Actions</th></tr></thead>";



        string myDateString;
        DateTime datetime;
        string s = "";
        while (dr.Read())
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
               
                if (dr.GetName(i).ToString() == "status" )
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
          

            string todate = "", fromdate = "" ;
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
            schedule = schedule + "<tr class='table-"+s+"'><td class='text-center' scope='row'>" + dr["id"].ToString() + "</td><td>" + dr["Jobcode"].ToString() + "</td><td>" + dr["sitename"].ToString() + "</td><td>" + dr["location"].ToString() + "</td><td>" + dr["workname"].ToString() + "</td><td>" + fromdate + "&nbsp; to &nbsp;" + todate + "</td><td> <span class='badge badge-" + s + "'>" + dr["status"].ToString() + "</span></td><td class='text-center'><div class='btn-group'><a href='details.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='View'><i class='fa fa-eye'></i></a><a href='scheduledit.aspx?id=" + dr["id"].ToString() + "' class='btn btn-sm btn-secondary' data-toggle='tooltip' title='Edit'><i class='fa fa-pencil'></i></a></div></td></tr>";
        }

        schedule = schedule + "</table>";

        dr.Close();
        con.Close();


        //SqlCommand cmd1 = new SqlCommand("select * from schedual",con);
        //con.Open();
        //SqlDataReader dr1;
        //dr1 = cmd1.ExecuteReader();
        export = sqlDisplaytable("select * from schedule");

   }
    public static string sqlDisplaytable(string query, string link = "", string btntext = "View More", string link2 = "", string btn2txt = "")
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        int c = 0;
        if (1 == 1)
        {

            //tabel start
          
            //genrating Tabel Headers
            data = data + " <thead > <tr >";
            for (int i = 0; i < dr.FieldCount; i++)
            {
                data = data + "<th>" + dr.GetName(i) + "</th>";
            }
            if (link != "")
                data = data + "<th>" + btntext + "</th>";
            if (link2 != "")
                data = data + "<th>" + btntext + "</th>";
            data = data + "</tr></thead>";
            //Genrating Data
            data = data + "<tbody>";
            string sold = "", snew = "default";
            while (dr.Read())
            {
                c++;
                if (sold != "")
                {
                    data = data + "<tr class='" + sold + "'>";
                }
                else
                    data = data + "<tr>";
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string s = "";
                    if (dr.GetName(i).ToString() == "status")
                    {


                        if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Pending")
                            s = "warning";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Ongoing" || dr[dr.GetName(i).ToString()].ToString().Trim() == "In Process")
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


                        data = data + "<td> <span class='badge badge-" + s + "'>" + dr[dr.GetName(i).ToString()].ToString() + "</span></td>";
                        //     sold = snew;
                        //   snew = s;
                    }
                    else if (dr.GetName(i).ToString() == "Filepath")
                    {
                        if (dr[dr.GetName(i).ToString()].ToString().Length > 2)
                        {
                            data = data + "<td><a href='" + dr[dr.GetName(i).ToString()].ToString() + "'><i class='fa fa-download'></i> </a></td>";
                        }
                        else
                        {
                            data = data + "<td></td>";
                        }
                    }
                    else if (dr.GetName(i).ToString() == "assignedemps")
                    {
                        data = data + "<td>" + expel.genrateemployeenames(dr[dr.GetName(i).ToString()].ToString()) + "</td>";
                    }
                    else if (dr.GetName(i).ToString() == "Cost")
                    {
                        data = data + "<td> ₹ " + dr[dr.GetName(i).ToString()].ToString() + "</td>";
                    }
                    else
                    {
                        data = data + "<td>" + dr[dr.GetName(i).ToString()].ToString() + "</td>";
                    }
                }
                if (link != "")
                    data = data + "<td><a class='btn btn-primary' href='" + link + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btntext + "</a></td>";
                if (link2 != "")
                    data = data + "<td><a class='btn btn-danger' href='" + link2 + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btn2txt + "</a></td> </tr>";
                else
                    data = data + "</tr>";
            }
            data = data + "</tbody>";
            //tabel end
         
            dr.Close();


        }
    

        cn.Close();


        return data;
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        //
    }
    protected void btnexport_ServerClick(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from schedule", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            DataRow dr1 = dt.NewRow();
            dr1[0]=dr["sitename"].ToString();
            dr1[1]=dr["workname"].ToString();
            dr1[2] = dr["fromdate"].ToString();
            dr1[3] = dr["todate"].ToString();
            dr1[4] = dr["location"].ToString();
            dr1[5] = expel.genrateemployeelist(dr["Jobcode"].ToString() + "' and id='" + dr["id"].ToString());
            dr1[6] = expel.getSingleData("select fname+' '+lname from employee where id=" + dr["teamleader"].ToString());
            //dr1[5] = dr["assignedemps"].ToString() + ",";
            //dr1[6] = dr["teamleader"].ToString() + ",";
            dr1[7] = dr["remark"].ToString();
            dr1[8] = dr["Jobcode"].ToString();
            dr1[9] = dr["uploadby"].ToString();
            dr1[10] = dr["status"].ToString();
           
            dr1[14] = dr["Jobdetail"].ToString();
           
            dt.Rows.Add(dr1);
          }
        grdexp.DataSource = dt;
        grdexp.DataBind();
    
        dr.Close();
        if(con.State!=ConnectionState.Closed)
        con.Close();
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
      //  grdexp.Visible = false;

    }
}