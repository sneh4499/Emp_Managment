 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class task_jcf_jcfp : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string jobs, jb,frm, id, jifno, clientname, address, jobdetail, teamleader, jobstsrtdate, jobfinished, remarksforjob, reson, colleagenames, whom, ynn, specialremark, formno,data;
    protected void Page_Load(object sender, EventArgs e)
    {
        try{
           // id=Request.QueryString["Id"].ToString();
            jobs = Request.QueryString["jobcode"].ToString();
        }
        catch{

            Response.Redirect("/task/work/jobcompletion.aspx");

        }

         

  
          jifno = expel.getSingleData("select jobcode from jcf where jobcode like '"+jobs+"'");
          jobfinished = expel.getSingleData("select jobfinishdate from jcf where jobcode like '" + jobs + "'");
          remarksforjob = expel.getSingleData("select remarkforjob from jcf where jobcode like '" + jobs + "'");
          reson = expel.getSingleData("select reason from jcf where jobcode like '" + jobs + "'");
          specialremark = expel.getSingleData("select specialremark from jcf where jobcode like '" + jobs + "'");

          jb = expel.getSingleData("select jobcode from jcf where jobcode like '"+jobs+"'");
          clientname = expel.getSingleData("select sitename from schedule where Jobcode like '" + jb + "' And jobcode like '" + jobs + "'");
          address = expel.getSingleData("select location from schedule where Jobcode like '" + jb + "' And jobcode like '" + jobs + "'");

         jobdetail = expel.getSingleData("select Jobdetail from schedule where Jobcode like '" + jb + "' And jobcode like '" + jobs + "'");
          jobstsrtdate = expel.getSingleData("select fromdate from schedule where Jobcode like '" + jb + "' And jobcode like '" + jobs + "'");
         frm = Convert.ToDateTime(jobstsrtdate).ToString("dd-MM-yyyy");
          colleagenames = expel.genrateemployeelist(jb);


          teamleader =expel.getSingleData("select fname+' '+lname from employee where id="+expel.getSingleData("select teamleader from schedule where Jobcode like '" + jb + "' And jobcode like '" + jobs + "'"));

          string jcddata = expel.getSingleData("select jobcode from jcd where jobcode like '"+jobs+"'");
          cn.Open();
          SqlCommand cmd12 = new SqlCommand("select * from jcd where jobcode like '" + jobs + "' And jobcode like '"+jcddata+"'",cn);

          SqlDataReader dr;
          dr = cmd12.ExecuteReader();

          data = data + "<table class='w-100 border-b'> <tr> <th>SR NO.</th> <th>JOB COMPLETION DETAAILS</th> <th>TO WHOME</th> <th>YES/NO/NA</th> </tr>";
          int c = 1;
        while(dr.Read())
        {
            data = data + "<tr> <td>" + c.ToString()+ "</td> <td>" + dr["jcdetails"].ToString() + "</td> <td>" + dr["towhom"].ToString() + "</td> <td>" + dr["ynn"].ToString() + "</td> </tr>";
            c++;
        }
        data = data + "  </table>";
        dr.Close();
        cn.Close();
    }
}