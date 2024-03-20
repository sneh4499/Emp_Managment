using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class department_index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    public string unm, pw;
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["email"] != null && Request.Cookies["password"] != null)
            {
                txtusermail.Text = Request.Cookies["email"].Value;
                txtpassword.Attributes["value"] = Request.Cookies["password"].Value;
                chk.Checked = true;
            }
        }
        //code for redirect if user is alredy loged in 
        try
        {
            if (Request.Cookies["role"].Value != null && Request.Cookies["email"].Value != null)
            {
                Response.Redirect("/department/" + Request.Cookies["role"].Value + "/index.aspx");

            }
           
        }
        catch
        {
           // Response.Redirect("~/index.aspx");
        //do nothing

        }

        
        //Session["username"] = null;
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {

        Boolean f;
        f = expel.autheticateUser(ReplaceSpecialCharacters(txtusermail.Text),ReplaceSpecialCharacters(txtpassword.Text));
        if (f == true)
        {
            string role;
            role=expel.getSingleData("select role from login where email like '" + txtusermail.Text + "'");
            Response.Cookies["role"].Value =role; 
            Response.Cookies["email"].Value = txtusermail.Text;

            Response.Redirect("/department/" + role + "/index.aspx");
         }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password....!')", true);
        }



        //try
        //{
        //    con.Open();
        //    string sql = "select username,email,password from login where email='" + txtusermail.Text + "' and password='" + txtpassword.Text + "'";

        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    da.Fill(ds);
        //    if (Convert.ToString(ds.Tables[0].Rows[0]["email"]) == null && Convert.ToString(ds.Tables[0].Rows[0]["password"]) == null)
        //    {
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password....!')", true);


        //    }
        //    else if (Convert.ToString(ds.Tables[0].Rows[0]["email"]) == "Admin@admin.com" && Convert.ToString(ds.Tables[0].Rows[0]["password"]) == "Admin")
        //    {
        //        SqlCommand cmd1 = new SqlCommand("select email,username from login where email=@email", con);
        //        cmd1.Parameters.AddWithValue("@email", txtusermail.Text);
        //        SqlDataReader dr1;
        //        dr1 = cmd1.ExecuteReader();
        //        dr1.Read();
        //       // string name1 = (dr1["username"].ToString());
        //       // Session["username"] = name1;
        //        //Session["email"] = txtusermail.Text;
        //        Response.Cookies["role"].Value = expel.getSingleData("select role from login where email like '" + txtusermail.Text + "'");
        //        Response.Cookies["email"].Value = txtusermail.Text;
        //        Response.Redirect("/department/admin/index.aspx");
        //    }
        //    else if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        SqlCommand cmd2 = new SqlCommand("select email,role from login where email=@email", con);
        //        cmd2.Parameters.AddWithValue("@email", txtusermail.Text);
        //        SqlDataReader dr2;
        //        dr2 = cmd2.ExecuteReader();
        //        dr2.Read();


        //       Response.Cookies["email"].Value = txtusermail.Text;
        //       Response.Cookies["role"].Value = expel.getSingleData("select role from login where email like '" + txtusermail.Text + "'");

        //       //string chk = Request.Form["remember"].ToString();
              
        //        Response.Redirect("/department/user/index.aspx");
        //    }
        //    else
        //    {
        //        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password....!')", true);
        //    }
           


        //}
             
        //catch
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password....!')", true);
        //}
       

    }
    public static string ReplaceSpecialCharacters(string strInput)
    {
        strInput = strInput.Replace("--", "++");
        strInput = strInput.Replace('&', ',');
        strInput = strInput.Replace("%", "[%]");
        strInput = strInput.Replace('+', ',');
      //  strInput = strInput.Replace("_", "[_]");
        strInput = strInput.Replace("[", "[[]");
        strInput = strInput.Replace("]", "[]]");
        strInput = strInput.Replace("'", "''");
        return strInput;
    }


}