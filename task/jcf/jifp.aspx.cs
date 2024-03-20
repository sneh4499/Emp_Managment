using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class task_jcf_jifp : System.Web.UI.Page
{
    public string jobs,schedual,todates,sitecontactname,siteemail,sitelandline, sitemobile, teammember, id, jobcode, clientname, clientaddress, plantsubstationname, jobthrough, addressoffice, mr1, mr2, contact1, contact2, landline1, landline2, visitfor, jobdetail, reasonforfree, travelby, travelto, Testcertificate, Testingequipment,remarks,teamleader,amount,reachingtime,reportingtime,passedbyreference,locationnew,frmdate;
    protected void Page_Load(object sender, EventArgs e)
    {

     
        try
        {
            schedual = Request.QueryString["sid"].ToString();
           // id=Request.QueryString["id"].ToString();
            jobs = expel.getSingleData("select jobcode from schedule where id=" + schedual);
        }
        catch
        {
            Response.Redirect("/task/work/jobcompletion.aspx");
        }
       // jobcode = expel.getSingleData("select jobcode from work");

        string sn = expel.getSingleData("select sitename from schedule where jobcode like '" + jobs + "' and id=" + schedual);

         sitecontactname = expel.getSingleData("select contactperson from site where sitename like '"+sn+"'");

       

         sitemobile = expel.getSingleData("select mobileno from site where sitename like '" + sn + "'");

         siteemail = expel.getSingleData("select email from site where sitename like '" + sn + "' ");
         sitelandline = expel.getSingleData("select Landline from site where sitename like '" + sn + "'");


         teammember = expel.genrateemployeelist(jobs,schedual);
        clientname = expel.getSingleData("select sitename from work where jobcode like '"+jobs+"'");
        clientaddress = expel.getSingleData("select worklocation from work where jobcode like '" + jobs + "'");
        plantsubstationname = expel.getSingleData("select worklocation from work jobcode like '" + jobs + "'");
        jobthrough = expel.getSingleData("select jobthrough from work where jobcode like '" + jobs + "'");

        addressoffice = expel.getSingleData("select officeaddress from work where jobcode like '" + jobs + "'");
        mr1 = expel.getSingleData("select contactpersonname from work where jobcode like '" + jobs + "'");
        mr2 = expel.getSingleData("select contactpersonname1 from work where jobcode like '" + jobs + "'");
        contact1 = expel.getSingleData("select mobileno from work where jobcode like '" + jobs + "'");
        contact2 = expel.getSingleData("select mobileno1 from work where jobcode like '" + jobs + "'");

        landline1 = expel.getSingleData("select landlineno from work where jobcode like '" + jobs + "'");
        landline2 = expel.getSingleData("select landlineno1 from work where jobcode like '" + jobs + "'");
        visitfor = expel.getSingleData("select Visitfor from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
        jobdetail = expel.getSingleData("select Jobdetail from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
        travelby = expel.getSingleData("select Travelby from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
        travelto = expel.getSingleData("select Travelto from schedule where Jobcode like '" + jobs + "' and id=" + schedual);

        todates = expel.getSingleData("select todate from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
       
            frmdate = expel.getSingleData("select fromdate from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
       
      

        Testcertificate = expel.getSingleData("select Testcertificate from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
        Testingequipment = expel.getSingleData("select Testingequipment from schedule where Jobcode like '" + jobs + "' and id=" + schedual);

        reasonforfree = expel.getSingleData("select reasonrfreeservice from work where jobcode like '" + jobs + "'");

        remarks = expel.getSingleData("select remark from schedule where Jobcode like '" + jobs + "' and id=" + schedual);
        teamleader = expel.getSingleData("select fname+' '+lname from employee where id=" + expel.getSingleData("select teamleader from schedule where Jobcode like '" + jobs + "' and id=" + schedual));
        amount = expel.getSingleData("select Amount from schedule where Jobcode like '" + jobs + "' and id=" + schedual);

        reachingtime = expel.getSingleData("select reachingtime from schedule where Jobcode like '" + jobs + "'  and id=" + schedual);
        reportingtime = expel.getSingleData("select Reportingtime from schedule where Jobcode like '" + jobs + "' and id=" + schedual);

        passedbyreference = expel.getSingleData("select reference from work where jobcode like '" + jobs + "'");

        locationnew = expel.getSingleData("select Location from work where jobcode like '" + jobs + "'");
    }
}