using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_company_add : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string id1;

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
                            cmd = new SqlCommand("select * from site where id=@id", con);
                            cmd.Parameters.AddWithValue("@id", id1);
                            SqlDataReader dr = cmd.ExecuteReader();
                            dr.Read();

                            txtsitename.Text = (dr["sitename"].ToString());
                            txtlocation.Text = (dr["location"].ToString());
                            txtcontactperson.Text = (dr["contactperson"].ToString());
                            txtmobileno.Text = (dr["mobileno"].ToString());
                            txtlongitude.Text = (dr["longitude"].ToString());
                            txtlatitude.Text = (dr["latitude"].ToString());
                            txtlandline.Text = (dr["Landline"].ToString());
                            txtemail.Text = (dr["email"].ToString());

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
        con.Open();
        cmd = new SqlCommand("insert into site (datetime,sitename,location,contactperson,mobileno,longitude,latitude,Landline,email) values (@datetime,@sitename,@location,@contactperson,@mobileno,@longitude,@latitude,@Landline,@email)", con);
        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@sitename", txtsitename.Text);
        cmd.Parameters.AddWithValue("@location", txtlocation.Text);
        cmd.Parameters.AddWithValue("@contactperson", txtcontactperson.Text);
        cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
        cmd.Parameters.AddWithValue("@longitude", txtlongitude.Text);
        cmd.Parameters.AddWithValue("@latitude", txtlatitude.Text);
        cmd.Parameters.AddWithValue("@Landline", txtlandline.Text);
        cmd.Parameters.AddWithValue("@email", txtemail.Text);
        cmd.ExecuteNonQuery();
        con.Close();

        txtsitename.Text = "";
        txtmobileno.Text = "";
        txtcontactperson.Text = "";
        txtlocation.Text = "";
        txtlandline.Text = "";
        txtemail.Text = "";
        Response.Redirect("view.aspx");

    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        id1 = Request.QueryString["id"].ToString();
        con.Open();
        cmd = new SqlCommand("Update site SET sitename=@sitename,location=@location,contactperson=@contactperson,mobileno=@mobileno,longitude=@longitude,latitude=@latitude,Landline=@Landline,email=@email where id=@id", con);
        cmd.Parameters.AddWithValue("@id", id1);
        cmd.Parameters.AddWithValue("@sitename", txtsitename.Text);
        cmd.Parameters.AddWithValue("@location", txtlocation.Text);
        cmd.Parameters.AddWithValue("@contactperson", txtcontactperson.Text);
        cmd.Parameters.AddWithValue("@mobileno", txtmobileno.Text);
        cmd.Parameters.AddWithValue("@longitude", txtlongitude.Text);
        cmd.Parameters.AddWithValue("@latitude", txtlatitude.Text);
        cmd.Parameters.AddWithValue("@Landline", txtlandline.Text);
        cmd.Parameters.AddWithValue("@email", txtemail.Text);

        cmd.ExecuteNonQuery();
        con.Close();


        Response.Redirect("view.aspx");
    }
}