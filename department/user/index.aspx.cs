using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class department_user_Default : System.Web.UI.Page
{
    public string totaltasks, employee, sid, pendingtask, data, img, days, hrs, frmfeatch, frm, tofeatch, to;

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
        try
        {
        }
        catch
        {
           
        }



     
 
        
        
        
        try
        {
         

            employee = expel.getSingleData("select id from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'");
            sid = expel.getSingleData("select id from schedule where assignedemps like '%" + employee + "%'");
     
            totaltasks = expel.getSingleData("select count(*) from schedule where assignedemps like '%" + employee + "%'");
            pendingtask = expel.getSingleData("select count(*) from schedule where  status like 'Pending' And assignedemps like '%" + employee + "%'");
           // days = expel.getSingleData("select count(*) from schedule where assignedemps like '%" + employee + "%'");
            hrs = expel.getSingleData("select count(DISTINCT Jobcode) from schedule where status like 'Completed' AND assignedemps like '%" + employee + "%'");
            frmfeatch = expel.getSingleData("select fromdate from schedule where status like 'Pending' And assignedemps like '%" + employee + "%'");
            frm = Convert.ToDateTime(frmfeatch).ToString("dd-MM-yyyy");

            tofeatch = expel.getSingleData("select todate from schedule where status like 'Pending' And assignedemps like '%" + employee + "%'");

            to = Convert.ToDateTime(tofeatch).ToString("dd-MM-yyyy");


    
    }
        catch
        {
            totaltasks = "0";
            pendingtask = "0";
            hrs = "0";
            days = "0";
        }

     //Response.Write("<script>alert('"+frm+"')</script>");
         //employee = expel.getSingleData("select id from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'");
        //data = expel.sqlDisplaytable("select id,sitename,workname,fromdate,todate,status from schedule where (status like 'Pending' OR status like 'In Process' ) And assignedemps like '%" + employee + "%'", "/task/schedule/details.aspx?id=", "View Detail");
        data = expel.sqlDisplaytable("select id,sitename,workname,fromdate,todate,status from schedule where (status like 'Pending' OR status like 'In Process') And (assignedemps like '" + employee + ",%' or assignedemps like '%," + employee + ",%' or assignedemps like '%," + employee + "' or assignedemps like '" + employee + "')", "/task/schedule/details.aspx?id=", "View Detail");
    }
}