using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class department_management_index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string emp, site, pendingwork, schedule, data = "", calandar = "", pending, completed, inprocess, pendingschedule, inprocessscedule, completedschedule, frmfeatch, frm, tofeatch, to;
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
        //try
        //{
        //    frmfeatch = expel.getSingleData("select fromdate from schedule where status like 'Pending'");
        //    frm = Convert.ToDateTime(frmfeatch).ToString("dd-MM-yyyy");

        //    tofeatch = expel.getSingleData("select todate from schedule where status like 'Pending'");

        //    to = Convert.ToDateTime(tofeatch).ToString("dd-MM-yyyy");
        //}
        //catch
        //{

        //}
        string cal = expel.getSingleData("select sitename,workname,fromdate,todate,location from scheduale");



		 try
        {
            calandar = expel.GenrateCalenderEvents("%%");
        }
        catch
        {

        }
        
        try
        {
            emp = expel.getSingleData("select count(*) from employee");
            site = expel.getSingleData("select count(*) from site");
            pendingwork = expel.getSingleData("select count(*) from work where Status like 'Pending'");
            schedule = expel.getSingleData("select count(*) from schedule where status like 'Pending'");
        }
        catch
        {
            emp = "0";
            site = "0";
            pendingwork = "0";
            schedule = "0";
        }
        string empname2 = expel.getSingleData("select assignemp from work");
        string empname = expel.getSingleData("select fname +'&nbsp' +lname from employee where id='" + empname2 + "'");
        //and CONVERT(Varchar(50), datetime)='" + DateTime.Today.ToShortDateString() + "'
        data = expel.sqlDisplaytable("select id,LEN(REPLACE(assignedemps, ',', ''))+1 AS [Total EMPLOYEE],workname As [Work Name],Jobcode As [Work Code],sitename As [Customer Name],fromdate As [From Date],todate As [To Date],Status as status from schedule where (Status like 'Pending' OR Status like 'In Process' )");

        pendingschedule = expel.getSingleData("select count(status) from schedule where status like 'Pending'");
        inprocessscedule = expel.getSingleData("select count(status) from schedule where status like 'In Process'");
        completedschedule = expel.getSingleData("select count(status) from schedule where status like 'Completed'");
      

    }
    protected void drdjobcode_SelectedIndexChanged(object sender, EventArgs e)
    {
        // string jb = expel.getSingleData("select Jobcode from schedule");
        string status = expel.getSingleData("select status from schedule where Jobcode like '" + drdjobcode.SelectedItem.Text + "'");

        try
        {
            if (status == "pending")
            {
                pending = "20";
            }
            else if (status == "In Process")
            {
                pending = "50";
            }

            else if (status == "Completed")
            {
                pending = "100";
            }
        }
        catch
        {
            pending = "0";
        }

       
    }
    
}