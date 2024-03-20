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
public partial class task_empcheckinout_checkinout : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string eid, sid, users, lati, longi, data, tm, photo;
    string employee;

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
       



        employee=expel.getSingleData("select id from employee where email like '"+Request.Cookies["email"].Value.ToString()+"'");
        sid = expel.getSingleData("select TOP 1 id from schedule where (assignedemps like '" + employee + ",%' or assignedemps like '%," + employee + ",%' or assignedemps like '%," + employee + "' or assignedemps like '" + employee + "') and fromdate like '" + DateTime.Today.ToString("yyyy-MM-dd") + "' and (status like 'Pending' OR status like 'In Process') ORDER BY id DESC");	
        //sid = expel.getSingleData("select TOP 1 id from schedule where assignedemps like '%" + employee + "%' AND fromdate like '" + DateTime.Today.ToString("yyyy-MM-dd") + "' ORDER BY id DESC");
        string status = expel.getSingleData("select count(*) from checkinout where sid like '" + sid + "' AND eid like '" + Request.Cookies["email"].Value.ToString() + "'");
        string status1 = expel.getSingleData("select max(checkin) from checkinout where sid like '" + sid + "' AND eid like '" + Request.Cookies["email"].Value.ToString() + "'");
        data = "Your Today's Task Is " + expel.getSingleData("select workname from schedule where id =" + sid) + " At " + expel.getSingleData("select location from schedule where id =" + sid);
        string team = expel.getSingleData("select teamleader from schedule where id=" + sid);
        string x = "select max(id) from schedule where (assignedemps like '" + employee + ",%' or assignedemps like '%," + employee + ",%' or assignedemps like '%," + employee + "') fromdate like '" + DateTime.Today.ToString("yyyy-MM-dd") + "' ORDER BY id DESC";
        //Response.Write("<script>alert('"+x+"')</script>");

		//Response.Write("<script language=javascript>alert('"+employee+sid+status+data+team+x+"');</script>");

        if (sid != "No Data Found")
        { 
        //scchedual code
            if (team == employee)
            {
                tm = "<a class='badge  badge-success' style='color:white'>You Are Team Leader</a>";
                btncheckout.Text = "Submit";
             }
            else
            {
                 tm = "<a class='badge  badge-success' style='color:white'>Your Truck Number Is " + team + "</a>";
                btncheckout.Text = "Submit";

            }
            string x2 = "";
            try
            {
                x2=Request.Cookies["checkin"].Value.ToString();
            }
            catch
            {
                x2="";
            }
            if(x2 !="")
            {
                //Response.Write("<script>alert('"+x2+"')</script>");

               
                btnout.Visible = true;
                btncheckin.Visible = false;
                btncheckout.Visible = true;
            }
            else
            {
                btnout.Visible = false;
                btncheckin.Visible = true;
                btncheckout.Visible = false;
            }

           
        }
        else
        {
        //office code
            string x1 = "";
            try
            {
                x1 = Request.Cookies["checkin1"].Value.ToString();
            }
            catch
            {
                x1 = "";
            }
            if (x1 != "")
            {
               // Response.Write("<script>alert('" + x1 + "')</script>");
                
                btnout.Visible = true;
                btncheckin.Visible = false;
                btncheckout.Visible =  false;
            }
            else
            {
               
                btnout.Visible = false;
                btncheckin.Visible = false;
                btncheckout.Visible = false;
            }

        }



      
       
        

        //try
        //{
        //    if (Request.Cookies["checkin"].Value.ToString() != null )
        //    {
        //       // Response.Write("<script>alert('" + employee + " " + sid + " " + team + " "+Request.Cookies["checkin"].Value.ToString()+"')</script>");
        //        btncheckin.Visible = false;
        //        btnout.Visible = true;
             



        //        tm = tm + "<a class='badge  badge-primary' style='color:white' href='" + expel.basepath + "/task/schedule/details.aspx?id=" + sid + "'>View More Details</a>";

        //    }
           
        //    else
        //    {
        //        if (status == "0")
        //        {

        //            btncheckin.Visible = true;
        //            btnout.Visible = false;
        //            tm = tm + "<a class='badge  badge-primary' style='color:white' href='" + expel.basepath + "/task/schedule/details.aspx?id=" + sid + "'>View More Details</a>";

        //        }
        //        else
        //        {
        //            btncheckin.Visible = false;
        //            btnout.Visible = false;
             
        //        }
        //      }
        //}
        //catch
        //{
        //    if (status == "0")
        //    {

        //        tm = tm + "<a class='badge  badge-primary' style='color:white' href='" + expel.basepath + "/task/schedule/details.aspx?id=" + sid + "'>View More Details</a>";

        //    }
        //}

      

        if (data.IndexOf("No Data Found") > 0 )
        {            
          
            tm = "";
            data = "You are not assigned to any project <br /> You have To Check In From Office";
            
           
        }
       
       else
        {
          
           
          // btncheckinoffice.Visible = true;

            // tm = "";
           // data = "You are not assigned to any project";
        }
    }

    //protected void btncheckin_Click(object sender, EventArgs e)
    //{
    //    btnout.Visible = true;
    //    btncheckin.Visible = false;
       
      
    //    //try
    //    //{
    //    //    users = Request.Cookies["useremail"].ToString();

    //    //    eid=Request.QueryString["id"].ToString();
    //    //}
    //    //catch
    //    //{ 

    //    //}
      
      
    //    cmd = new SqlCommand("insert into checkinout (datetime,checkin) values (@datetime,@checkin)", con);
    //    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
    //    cmd.Parameters.AddWithValue("@checkin", "IN");
    //    expel.getSingleData("update work set Status='Process' where assignemp=" + eid);

    //    con.Open();
    //    cmd.ExecuteNonQuery();
    //    con.Close();
    //}

    //protected void btncheckout_Click(object sender, EventArgs e)
    //{
    //    btncheckin.Visible = true;
    //    btnout.Visible = false;
    //    cmd = new SqlCommand("insert into checkinout (datetime,checkout,description) values (@datetime,@checkout,@description)", con);
    //    cmd.Parameters.AddWithValue("@datetime", DateTime.Now);
    //    cmd.Parameters.AddWithValue("@checkout", "OUT");
    //    cmd.Parameters.AddWithValue("@description", txtdescription.Text);
    //    expel.getSingleData("update work set Status='Completed' where assignemp=" + eid);
    //    con.Open();
    //    cmd.ExecuteNonQuery();
    //    con.Close();


    //}
    protected void btncheckin_Click1(object sender, EventArgs e)
    {
        eid = Request.Cookies["email"].Value.ToString();
         
        try
        {
             lati=Request.QueryString["lat"].ToString();
        longi=Request.QueryString["long"].ToString();
        }
              
        catch
        {

        }

        
        expel.insert("checkinout",DateTime.Now.ToString(),DateTime.Now.ToString(),"","",lati,longi,eid,sid,"");
        expel.update("schedule", "status", "In Process", "id", sid);

        Response.Cookies["checkin"].Value = DateTime.Now.ToString();
        Response.Redirect("checkinout.aspx");
    }
    protected void btncheckout_Click1(object sender, EventArgs e)
    {
        


         eid = Request.Cookies["email"].Value.ToString();
         String mxdate = expel.getSingleData("select max(datetime) from checkinout where eid like '" + eid + "' And sid like '" + sid + "' ");
         expel.update("checkinout", "checkout", DateTime.Now.ToString(), "1", "1 AND eid like '" + eid + "' And sid like '" + sid + "'");

         expel.update("checkinout", "description", txtdescription.Text, "1", "1 AND eid like '" + eid + "' And sid like '" + sid + "'");
         Response.Cookies["checkin"].Expires = DateTime.Now.AddDays(-1d);


         try
         {
             string file = fuimg.FileName.Replace(".", System.DateTime.Now.ToString("ddMMyyhhmmss."));


             string Document_Path = Server.MapPath("~/data/" + Path.GetFileName(file));
             fuimg.SaveAs(Document_Path);

             photo = "/data/" + Path.GetFileName(file);
         }
         catch
         {
             photo = "0";
         }


         SqlCommand cmd = new SqlCommand("update checkinout set photo='"+photo+"' where eid like '"+eid+"' and sid like '"+sid+"'",con);
         con.Open();
         cmd.ExecuteNonQuery();
         con.Close();

        // expel.update("checkinout", "photo", photo, "1", "1 AND eid like '" + eid + "' And sid like '" + sid + "'");
       
         expel.update("schedule", "status", "Completed", "id", sid);
           
         

    }
   
}