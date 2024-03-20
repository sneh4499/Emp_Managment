using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class task_schedule_scheduledit : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string id1, emplistsel = "", emptl = "", visit = "", visitfr = "", fromdate = "", todate = "";
    public static string emp = "", visitforo = "", job = "", jobcodelist = "", emp1 = "", teamleader = "";

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


        if (!Page.IsPostBack)
        {
            BindTime();
        }


        con.Open();
        string str1 = "select id,fname,lname from employee";
        SqlCommand cmdemp = new SqlCommand(str1, con);
        emp = "";
        SqlDataReader dremp;
        dremp = cmdemp.ExecuteReader();
        while (dremp.Read())
        {
            Session["fname"] = dremp["fname"].ToString();
            Session["lname"] = dremp["lname"].ToString();

            emp = emp + " <option value='" + dremp["id"].ToString() + "'>" + dremp["fname"].ToString() + " " + dremp["lname"].ToString() + "</option>";
        }

        dremp.Close();
        con.Close();


        con.Open();
        string str20 = "select Name from schecklist";
        SqlCommand cmdvisit = new SqlCommand(str20, con);
        visitforo = "";
        SqlDataReader drvisit;
        drvisit = cmdvisit.ExecuteReader();
        while (drvisit.Read())
        {
            Session["Name"] = drvisit["Name"].ToString();


            visitforo = visitforo + " <option value='" + drvisit["Name"].ToString() + "'>" + drvisit["Name"].ToString() + "</option>";
        }
        drvisit.Close();
        con.Close();

        if (!IsPostBack)
        {
           
            try
            {


                con.Open();


                id1 = Request.QueryString["id"].ToString();

                if (Request.QueryString["id"].ToString() != null)
                {
                    cmd = new SqlCommand("select * from schedule where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id1);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    drdjobcode.SelectedItem.Text = dr["jobcode"].ToString();
                    dropsitename.SelectedItem.Text = (dr["sitename"].ToString());
                    drdworkname.SelectedItem.Text = (dr["workname"].ToString());
                    fromdate = dr["fromdate"].ToString();
                    todate = dr["todate"].ToString();

                    txttodate.Text = Convert.ToDateTime(dr["todate"]).ToString("yyyy-MM-dd HH:mm:ss");
                    txtfromdate.Text = Convert.ToDateTime(dr["fromdate"]).ToString("yyyy-MM-dd HH:mm:ss");
                    txtlocation.Text = (dr["location"].ToString());
                    //assignemp.Text = (dr["assignedemps"].ToString());
                    teamleader = expel.genratedata(dr["teamleader"].ToString(), "employee","fname");

                    emp1 = expel.genrateemployeelist(drdjobcode.SelectedItem.Text,id1);
                    visitfr = dr["Visitfor"].ToString();
                    // Response.Write("<script>document.getElementById('emplist').value ="+emp1+" '</script>");
                    // Response.Write("<script>document.getElementById('emplist').text =" + emp1 + " '</script>");
                    // Response.Write("<script>document.getElementById('emplist').innerHtml =" + emp1 + " '</script>");
                    txtremark.Text = (dr["remark"].ToString());

                    txtjobdetail.Text = (dr["Jobdetail"].ToString());
                    rdbtnvehicleplanning.Text = (dr["Travelby"].ToString());
                    txttravelto.Text = (dr["Travelto"].ToString());
                    txtamount.Text = (dr["Amount"].ToString());
                    drdtestingcertificate.SelectedItem.Text = (dr["Testcertificate"].ToString());
                    drdtestingequipment.SelectedItem.Text = (dr["Testingequipment"].ToString());

                    drdreachingtime.SelectedValue = dr["reachingtime"].ToString();
                    drdreportingtime.SelectedValue = dr["Reportingtime"].ToString();


                    dr.Close();
                    con.Close();
                  
                }
                else
                {
                 
                }


            }
            catch
            {
                teamleader = "0";
                emp1 = "0";
                visitfr = "0";
                //  Response.Redirect("view.aspx");

            }


            return;
        }

    }
    public static string genratenotification(string seduleempname, string notification)
    {

        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname = "";

        int n;
        try
        {
            n = seduleempname.Split(',').Length + 1;
        }
        catch
        {
            n = 0;
        }

        while (i < n)
        {

            try
            {
                emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                emp[i] = expel.getSingleData("select email from employee where id=" + emp[i]);
                expel.insert("notification", emp[i], notification, "1");

            }
            catch
            {
                emp[i] = seduleempname;
                emp[i] = expel.getSingleData("select email from employee where id=" + emp[i]);
                expel.insert("notification", emp[i], notification, "1");
            }
            cname = cname + emp[i] + ",";
            i++;
        }
        try
        {
            cname = cname.Substring(0, cname.Length - 1);
        }
        catch
        {
            cname = "";
        }

        return cname;
    }
    private void BindTime()
    {
        // Set the start time (00:00 means 12:00 AM)
        DateTime StartTime = DateTime.ParseExact("00:00", "HH:mm", null);
        // Set the end time (23:55 means 11:55 PM)
        DateTime EndTime = DateTime.ParseExact("23:55", "HH:mm", null);
        //Set 5 minutes interval
        TimeSpan Interval = new TimeSpan(0, 15, 0);
        //To set 1 hour interval
        //TimeSpan Interval = new TimeSpan(1, 0, 0);           
        drdreachingtime.Items.Clear();
        drdreportingtime.Items.Clear();
        while (StartTime <= EndTime)
        {
            drdreachingtime.Items.Add(StartTime.ToShortTimeString());
            drdreportingtime.Items.Add(StartTime.ToShortTimeString());
            StartTime = StartTime.Add(Interval);
        }
        drdreachingtime.Items.Insert(0, new ListItem("--Select--", "0"));
        drdreportingtime.Items.Insert(0, new ListItem("--Select--", "0"));
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
          try
        {
            emplistsel = Page.Request.Form["emplist"].ToString();
            emptl = Page.Request.Form["emptl"].ToString();
            visit = Page.Request.Form["visitforlist"].ToString();
            //jobcodelist = Page.Request.Form["jobcodelist"].ToString();
        }
        catch
        {
            emplistsel = "";
            emptl = "";
            visit = "";
            jobcodelist = "";

        }
        id1 = Request.QueryString["id"].ToString();
        con.Open();
        cmd = new SqlCommand("Update schedule SET sitename=@sitename,workname=@workname,todate=@todate,fromdate=@fromdate,location=@location,assignedemps=@assignedemps,teamleader=@teamleader,remark=@remark,Visitfor=@Visitfor,Travelby=@Travelby,Travelto=@Travelto,Jobdetail=@Jobdetail,Testcertificate=@Testcertificate,Testingequipment=@Testingequipment,reachingtime=@reachingtime,Reportingtime=@Reportingtime,Amount=@Amount where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id1);
        cmd.Parameters.AddWithValue("@sitename", dropsitename.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@workname", drdworkname.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@todate", txttodate.Text);
        cmd.Parameters.AddWithValue("@fromdate", txtfromdate.Text);
        cmd.Parameters.AddWithValue("@location", txtlocation.Text);
       cmd.Parameters.AddWithValue("@assignedemps", emplistsel);
        cmd.Parameters.AddWithValue("@teamleader", emptl);
        cmd.Parameters.AddWithValue("@remark", txtremark.Text);
        cmd.Parameters.AddWithValue("@Jobcode", drdjobcode.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Visitfor", visit);
        cmd.Parameters.AddWithValue("@Travelby", rdbtnvehicleplanning.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Travelto", txttravelto.Text);
        cmd.Parameters.AddWithValue("@Jobdetail", txtjobdetail.Text);
        cmd.Parameters.AddWithValue("@Testcertificate", drdtestingcertificate.Text);
        cmd.Parameters.AddWithValue("@Testingequipment", drdtestingequipment.Text);
        cmd.Parameters.AddWithValue("@reachingtime", drdreachingtime.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Reportingtime", drdreportingtime.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@Amount", txtamount.Text);
        

        cmd.ExecuteNonQuery();
          string a = Request.Cookies["email"].Value.ToString();
        string aaa = expel.getSingleData("select max(id) from schedule where Jobcode like '" + drdjobcode.SelectedItem.Text + "'");

       
         SqlCommand cmd1 = new SqlCommand("update calenders set text='" + dropsitename.SelectedItem.Text + " : " + drdworkname.SelectedItem.Text + "',taskname='" + expel.getSingleData("select id from schedule where id=" + aaa) + "',date='" + txtfromdate.Text.ToString() + "',userid='" + a + "',enddate='" + txttodate.Text.ToString() + "' where id="+id1,con);
         cmd1.ExecuteNonQuery();
         genratenotification(emplistsel, "You are Assigned to job " + drdjobcode.SelectedItem.Text + " At " + txtlocation.Text + " On " + DateTime.Parse(txtfromdate.Text).ToString("dd-MM-yy"));

        con.Close();


        Response.Redirect("view.aspx");
    }

    protected void drdjobcode_SelectedIndexChanged(object sender, EventArgs e)
{
        dropsitename.SelectedItem.Text = expel.getSingleData("select sitename from work where jobcode like '" + drdjobcode.SelectedItem.Text + "'");
        txtlocation.Text = expel.getSingleData("select worklocation from work where jobcode like '" + drdjobcode.SelectedItem.Text + "'");

        drdworkname.SelectedItem.Text = expel.getSingleData("select workname from work where jobcode like '" + drdjobcode.SelectedItem.Text + "'");
}
}