using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class task_jcf_jcf : System.Web.UI.Page
{
    public static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string data = "", formats = "", srno = "", formats1 = "", jobs="",data1;

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
        if (cn.State == ConnectionState.Open)
            cn.Close();
        // string empid = expel.getSingleData("select id from employee");
        try
        {
            jobs=Request.QueryString["jobcode"].ToString();
        }
        catch
        {
            Response.Redirect("joblist.aspx");
        }



        txtjobcode.Text = expel.getSingleData("select jobcode from schedule where Jobcode like '"+jobs+"'");
        string seduleempname = expel.getSingleData("select assignedemps from schedule where jobcode like '" + jobs + "'");
        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname="";
        int n;
        try
        {
            n = seduleempname.Split(',').Length + 1;
        }
        catch
        {
            n = 0;
        }
        n = Int32.Parse(expel.getSingleData("select LEN(REPLACE(assignedemps, ',', '')) from schedule where jobcode like '" + jobs + "'"));
        while (i<n-1)
        {
            
                try
                {
                    emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                    seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                    emp[i] = expel.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);
                }
                catch
                {
                    emp[i] = seduleempname;
                    emp[i] = expel.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);
                }
                cname=cname+emp[i]+",";
               i++;
        }
        cname = cname.Substring(0, cname.Length-1);
      
        string empname = expel.getSingleData("select fname from employee where id=" + seduleempname);

        txtclientname.Text = expel.getSingleData("select sitename from schedule where jobcode='" + jobs + "'");
        txtaddress.Text = expel.getSingleData("select location from schedule where jobcode='" + jobs + "'");
        txtjobdetails.Text = expel.getSingleData("select jobdetail from schedule where jobcode='" + jobs + "'");
      

        try
        {
            string dd = expel.getSingleData("select fromdate from schedule where jobcode='" + jobs + "'");
            txtstartdate.Text = Convert.ToDateTime(dd).ToString("dd-MM-yyyy");
            string yy = DateTime.Now.ToString("yyyy-MM-dd");
            txtfinishdate.Text = Convert.ToDateTime(yy).ToString("dd-MM-yyyy");
           
        }
        catch
        {
            txtstartdate.Text = expel.getSingleData("select fromdate from schedule where jobcode='" + jobs + "'");

            txtfinishdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        txtcolleaguesname.Text = expel.genrateemployeelist(jobs); ;




        
        i = 1;
        i++;
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from jcbformat",cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        
       // data = data + " <table class='table table-bordered table-striped table-vcenter'><thead> <tr> <th class='text-center'>Sr No</th> <th>Job Complition Details</th> <th class='d-none d-sm-table-cell'>To Whom</th> <th class='d-none d-sm-table-cell' style='width: 15%;'>Yes/No/NA</th> </tr> </thead>";
       
        while(dr.Read())
        {
            srno=dr["Id"].ToString();
            formats=dr["Name"].ToString();
          
            data = data + "<div class='row'> <div class='col-md-2'>" + srno + "</div> <div class='col-md-4'>" + formats + "</div> <div class='col-md-3'> <input type='text' class='form-control' id='w" + i + "' name='whom' required /> </div><div class='col-md-3'><select class='form-control'  id='w1" + i + "' name='drd' required> <option value='Yes'>Yes</option> <option value='No'>No</option> <option value='NA'>NA</option> </select></div> </div>";

           // data = data + "<tbody> <tr> <td class='text-center'>" + srno + "</td> <td class='font-w600'>" + formats + "</td> <td class='d-none d-sm-table-cell'><input type='text' id='w" + i + "' name='whom' required /> </td> <td class='d-none d-sm-table-cell'> <select class='form-control'  id='w1" + i + "' name='drd' required> <option value='Yes'>Yes</option> <option value='No'>No</option> <option value='NA'>NA</option> </select> </td> </tr> </tbody>";

        }
        data = data + "</table>";
        dr.Close();
        cn.Close();
        
       // formats = expel.getSingleData("select Name from jcbformat");
        //string srno = expel.getSingleData("select Id from jcbformat");
      

       

      
    }
    //protected void droppriority_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //   // string empid = expel.getSingleData("select id from employee");

    //    string seduleempname = expel.getSingleData("select assignedemps from schedule where jobcode like '" + droppriority.SelectedItem.Text + "'");
    //    //string[] emp = new string[100];
    //    //emp[0]=seduleempname.Substring(0,seduleempname.IndexOf(","));
    //    //seduleempname=seduleempname.Substring(0,seduleempname.IndexOf(","));
    //    //int i=1;
    //    //while(seduleempname.IndexOf(", "))
    //    //{

    //    //   emp[i]=seduleempname.Substring(0,seduleempname.IndexOf(","));
    //    //   seduleempname=seduleempname.Substring(0,seduleempname.IndexOf(","));
    //    //   i++;
    //    //}
    //    string empname = expel.getSingleData("select fname from employee where id=" + seduleempname);
       
    //    txtclientname.Text = expel.getSingleData("select sitename from schedule where jobcode='" + droppriority.SelectedItem.Text + "'");
    //    txtaddress.Text = expel.getSingleData("select location from schedule where jobcode='" + droppriority.SelectedItem.Text + "'");
    //    txtjobdetails.Text = expel.getSingleData("select jobdetail from schedule where jobcode='" + droppriority.SelectedItem.Text + "'");
    //    txtstartdate.Text = expel.getSingleData("select fromdate from schedule where jobcode='" + droppriority.SelectedItem.Text + "'");
    //    txtfinishdate.Text = DateTime.Now.ToShortDateString();
    //    txtcolleaguesname.Text = expel.getSingleData("select assignedemps from schedule where jobcode='" + droppriority.SelectedItem.Text + "'");

    //}

    protected void btnsave_Click(object sender, EventArgs e)
    {
        expel.insert("jcf", jobs, txtfinishdate.Text, drdremarksforjob.SelectedItem.Text, txtreason.Text, txtspecialremarks.Text, DateTime.Now.ToString(),Request.Cookies["email"].Value.ToString());

        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from jcbformat", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        string whome = Request.Form["whom"].ToString();
        string ynn = Request.Form["drd"].ToString();
       // Response.Write("<script>alert('" + whome + "')</script>");
        string whomedata = "", form11 = "", ynndata = "";
        while(dr.Read())
        {
            try
            {
                form11 = dr["Name"].ToString();
                whomedata = whome.Substring(0, whome.IndexOf(","));
                whome = whome.Substring(whome.IndexOf(",") + 1);
                ynndata = ynn.Substring(0,ynn.IndexOf(","));
                ynn = ynn.Substring(ynn.IndexOf(",") + 1);
               
            }
            catch
            {
                whomedata = whome;
                ynndata = ynn;
            }
            //Response.Write("<script>alert('" + whome + "')</script>");
            expel.insert("jcd", jobs, form11, whomedata, ynndata, DateTime.Now.ToString(), Request.Cookies["email"].Value.ToString());
           
        }
        dr.Close();
        string sid = "";
        try
        {
            sid = Request.QueryString["sid"].ToString();
        }
        catch
        {

        }
        
        
        
        expel.update("schedule", "status", "Submitted", "id", sid);
        
        
        
        
        //SqlCommand cmd1 = new SqlCommand("delete from jcd where towhom=''", cn);
       // cmd1.ExecuteNonQuery();
        cn.Close();
       // Response.Redirect("joblist.aspx");
        Response.Redirect("/task/emptask/emptask.aspx");

        txtaddress.Text = "";
        txtclientname.Text = "";
        txtcolleaguesname.Text = "";
        txtfinishdate.Text = "";
        txtjobdetails.Text = "";
        txtreason.Text = "";
        txtspecialremarks.Text = "";
        txtstartdate.Text = "";
            
       

    }
    protected void drdremarksforjob_SelectedIndexChanged(object sender, EventArgs e)
    {
        cn.Open();
        string id = expel.getSingleData("select id from work where Jobcode like '" + jobs + "'");
       
        SqlCommand cmd = new SqlCommand("update work set Status='"+drdremarksforjob.SelectedItem.Text+"' where id="+id,cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        //expel.update("work", "Status",drdremarksforjob.SelectedItem.Text, "id", id);
    }
}