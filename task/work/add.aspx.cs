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
using System.IO;
using System.Configuration;
public partial class task_work_add : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string id1;
    public static string emp = "", eid,img,lastjob="";
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
       

       
        con.Open();
        string str1 = "select id,fname,lname from employee";
        SqlCommand cmdemp = new SqlCommand(str1, con);

        SqlDataReader dremp;
        dremp = cmdemp.ExecuteReader();
        while (dremp.Read())
        {
            emp = emp + " <option value='" + dremp["id"].ToString() + "'>" + dremp["fname"].ToString() + " " + dremp["lname"].ToString() + "</option>";
        }
        dremp.Close();
        con.Close();

        lastjob = expel.getSingleData("select jobcode from work where id=(select max(id) from work)");
        //con.Open();
        //string str = "select sitename from site";
        //SqlCommand cmd = new SqlCommand(str, con);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //dropsitename.DataSource = ds;
        //dropsitename.DataTextField = "sitename";
        //dropsitename.DataBind();
        //con.Close();



     

        btnupdate.Visible = false;
        update.Visible = false;

          if (!IsPostBack)
                {

                    try
                    {

                        id1 = Request.QueryString["id"].ToString();
                        con.Open();
                        if (Request.QueryString["id"].ToString() != null)
                        {
                            cmd = new SqlCommand("select * from work where id=@id", con);
                            cmd.Parameters.AddWithValue("@id", id1);
                            SqlDataReader dr = cmd.ExecuteReader();
                            dr.Read();
                         
                           
                            txtworkname.Text = (dr["workname"].ToString());
                            txtlocation.Text = (dr["worklocation"].ToString());
                            txtfromdate.Text = (dr["timefrom"].ToString());
                            txttodate.Text = (dr["timeto"].ToString());
                            droppriority.SelectedItem.Text = (dr["workpriority"].ToString());
                            txtdescription.Text = (dr["description"].ToString());
                            dropsitename.SelectedItem.Text = (dr["sitename"].ToString());
                            txtjobcode.Text = (dr["jobcode"].ToString());
                       
                            //txtpono.Text = (dr["pono"].ToString());
                            
                            txtlocation1.Text = dr["Location"].ToString();

                            dr.Close();
                            con.Close();
                            btnupdate.Visible = true;
                            btnsave.Visible = false;
                            insert.Visible = false;
                            update.Visible = true;
                        }
                        else
                        {
                            btnupdate.Visible = false;
                            btnsave.Visible = true;
                            insert.Visible = true;
                            update.Visible = false;
                        }

                    }
                    catch
                    {

                    }


                    return;
                }
      
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
       // string emplistsel = Page.Request.Form["emplist"].ToString();
        //string emplistsel="";
     


         eid = "";
         cmd = new SqlCommand("insert into work (datetime,workname,sitename,worklocation,timefrom,timeto,workpriority,assignemp,description,Status,jobcode,reference,pono,Location) values (@datetime,@workname,@sitename,@worklocation,@timefrom,@timeto,@workpriority,@assignemp,@description,@Status,@jobcode,'',@Location)", con);
        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@workname", txtworkname.Text);
        cmd.Parameters.AddWithValue("@sitename", dropsitename.Text);
        cmd.Parameters.AddWithValue("@worklocation", txtlocation.Text);
        cmd.Parameters.AddWithValue("@timefrom", txtfromdate.Text);
        cmd.Parameters.AddWithValue("@timeto", txttodate.Text);
        cmd.Parameters.AddWithValue("@workpriority", droppriority.Text);
        cmd.Parameters.AddWithValue("@assignemp", eid);
       
        cmd.Parameters.AddWithValue("@description", txtdescription.Text);
        cmd.Parameters.AddWithValue("@Status", "Pending");
        cmd.Parameters.AddWithValue("@jobcode", txtjobcode.Text);
        cmd.Parameters.AddWithValue("@reference", drdreference.SelectedItem.Text);
        //cmd.Parameters.AddWithValue("@pono", txtpono.Text);
        cmd.Parameters.AddWithValue("@Location", txtlocation1.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        txtworkname.Text = "";
        txtlocation.Text = "";
        txtfromdate.Text = "";
        txttodate.Text = "";
        droppriority.Text = "";
        txtdescription.Text = "";
        txtlocation1.Text = "";
        Response.Redirect("view.aspx");
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        id1 = Request.QueryString["id"].ToString();
        string emplistsel = "";
        try
        {
            emplistsel = Page.Request.Form["emplist"].ToString();
        }
        catch
        {
            emplistsel = "";
        }




        cmd = new SqlCommand("update work Set workname=@workname,sitename=@sitename,worklocation=@worklocation,timefrom=@timefrom,timeto=@timeto,workpriority=@workpriority,description=@description,jobcode=@jobcode,reference=@reference,pono='',Location=@Location where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id1);
        cmd.Parameters.AddWithValue("@workname", txtworkname.Text);
        cmd.Parameters.AddWithValue("@sitename", dropsitename.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@worklocation", txtlocation.Text);
        cmd.Parameters.AddWithValue("@timefrom", txtfromdate.Text);
        cmd.Parameters.AddWithValue("@timeto", txttodate.Text);
        cmd.Parameters.AddWithValue("@workpriority", droppriority.SelectedItem.Text);
        // cmd.Parameters.AddWithValue("@assignemp", eid);
         cmd.Parameters.AddWithValue("@files", img);
        cmd.Parameters.AddWithValue("@description", txtdescription.Text);
        cmd.Parameters.AddWithValue("@jobcode", txtjobcode.Text);

        cmd.Parameters.AddWithValue("@reference", drdreference.SelectedItem.Text);
        //cmd.Parameters.AddWithValue("@pono", txtpono.Text);
       
        cmd.Parameters.AddWithValue("@Location", txtlocation1.Text);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("view.aspx");
    }
    protected void dropsitename_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtlocation.Text = expel.getSingleData("select location from site where sitename like '" + dropsitename.SelectedItem.Text + "'");
    }
   
}