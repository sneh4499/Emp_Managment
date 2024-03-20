using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_department_add : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string id1="",data;

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
        data = expel.sqlDisplaytable("select deptname As [Department Name],parentdept As [Parent Department] from department");
        con.Open();
        string str = "select deptname from department";
        SqlCommand cmd = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dropparentdept.DataSource = ds;
        dropparentdept.DataTextField = "deptname";
        dropparentdept.DataBind();
        con.Close();


        btnupdate.Visible = false;
        update.Visible = false;
        try
        {

            id1 = Request.QueryString["id"].ToString();
         
            if (Request.QueryString["id"].ToString() != null)
            {
                con.Open();
                cmd = new SqlCommand("select * from department where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id1);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                txtdepartmentname.Text = (dr["deptname"].ToString());
                dropparentdept.Text = (dr["parentname"].ToString());
                

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
    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        
            con.Open();
            cmd = new SqlCommand("insert into department (deptname,parentdept) values (@deptname,@parentdept)", con);
            cmd.Parameters.AddWithValue("@deptname", txtdepartmentname.Text);
            cmd.Parameters.AddWithValue("@parentdept", dropparentdept.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        
        txtdepartmentname.Text = "";
       
        Response.Redirect("view.aspx");
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        id1 = Request.QueryString["id"].ToString();

        cmd = new SqlCommand("update department Set deptname,parentdept where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id1);
        cmd.Parameters.AddWithValue("@deptname", txtdepartmentname.Text);
        cmd.Parameters.AddWithValue("@parentdept", dropparentdept.Text);
        
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("view.aspx");
    }
}