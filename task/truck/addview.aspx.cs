using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class task_truck_addview : System.Web.UI.Page
{
    public string data = "", id1 = "";
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
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
        data = expel.sqlDisplaytable("select Id,trucknumber as[Truck Number] from truck", "addview.aspx?Id=", "Edit", "addview.aspx?cmd=del&Id=", "Delete");
        try
        {
            id1 = Request.QueryString["id"].ToString();
        }
        catch
        {

        }


        if (!IsPostBack)
        {
            string del = "";
            try
            {
                del = Request.QueryString["cmd"].ToString();
            }
            catch
            { }


            if (del == "del")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete from truck where Id=" + id1, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("addview.aspx");

            }
            else
            {


                btnupdate.Visible = false;
                update.Visible = false;
                try
                {


                    con.Open();



                    if (Request.QueryString["id"].ToString() != null)
                    {
                        cmd = new SqlCommand("select * from truck where Id=@Id", con);
                        cmd.Parameters.AddWithValue("@Id", id1);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        txtnumber.Text = dr["trucknumber"].ToString();

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

                    //  Response.Redirect("view.aspx");

                }
            }

            return;
        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        expel.insert("truck", txtnumber.Text);
        Response.Redirect(Request.RawUrl);
        txtnumber.Text = "";
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("update truck set trucknumber='" + txtnumber.Text + "' where Id='" + id1 + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("addview.aspx");
    }
}