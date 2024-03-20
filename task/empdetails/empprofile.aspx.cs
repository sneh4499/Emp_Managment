using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class task_empdetails_empprofile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string username;
    public string emp, pro="";

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
        if (Request.Cookies["email"].ToString() != null)
        {


            con.Open();

            SqlCommand cmd = new SqlCommand("select * from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'", con);

            cmd.ExecuteNonQuery();
            //SqlDataReader dr;
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //     pro = expel.getSingleData("select * from employee where email like '" + Request.Cookies["email"].Value.ToString() + "'");

              
            //    //emp = "<div class='bg-image bg-image-bottom mt-15 mr-15 ml-15' style='background-image:linear-gradient(135deg,#d262e3 0,#3f9ce8 100%);'> <div class='content content-full text-center pb-1'> <div class='mb-15'> <div class='img-link'> <img class='img-avatar img-avatar96 img-avatar-thumb' src='../../assets/media/avatars/avatar15.jpg' alt='No Image'> </div> </div> <h1 class='h3 text-white font-w700 mb-10'>" + dr["fname"].ToString() + " " + dr["lname"].ToString() + " <small class=' text-white'>(" + dr["gender"].ToString() + ")</small> </h1> <h2 class='h5 text-white-op'>" + dr["designation"].ToString() + "</h2> </div> </div> <div class='row ml-0 mr-0 mt-15 detail_page'> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Personal Info</h3> </div> <div class='block-content'> <address class='detail_personal'> <i class='fa fa-map-marker' aria-hidden='true'></i> <p class='address_div'>" + dr["address"].ToString() + "<br> " + dr["city"].ToString() + " - " + dr["pincode"].ToString() + " <br>" + dr["state"].ToString() + " <br>" + dr["country"].ToString() + " </p> <br> <i class='fa fa-phone mr-5'></i>" + dr["mobileno"].ToString() + "<br> <i class='fa fa-envelope-o mr-5'></i><a href='javascript:void(0)'>" + dr["email"].ToString() + "</a> </address> </div> </div> </div> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Eduction Info</h3> </div> <div class='block-content'> <address> <div class='font-size-lg text-black mb-5'>Qualification</div> <strong>Degree : </strong> " + dr["qualification"].ToString() + "<br> <strong>Year : </strong>" + dr["passingyear"].ToString() + "<br> <strong>Percentage : </strong>" + dr["persentage"].ToString() + "%<br> </address> <address> <div class='font-size-lg text-black mb-5'>Experiance</div> <strong>Company Name : </strong>" + dr["expicompanyname"].ToString() + "<br> <strong>Duration : </strong>" + dr["expiduration"].ToString() + "<br> <strong>Designation : </strong>" + dr["expidesignation"].ToString() + "<br> </address> </div> </div> </div> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Bank Info</h3> </div> <div class='block-content'> <address> <strong>Bank Name : </strong>" + dr["bankname"].ToString() + "<br> <strong>A/c No : </strong>" + dr["accountno"].ToString() + "<br> <strong>IFSC No : </strong>" + dr["ifsccode"].ToString() + " <br><br> <strong>Id Type : </strong>" + dr["idproof"].ToString() + "<br> <strong>Id No : </strong>" + dr["idproofno"].ToString() + "<br> <strong>PAN No : </strong>" + dr["pancardno"].ToString() + "<br> </address> </div> </div> </div> </div> <div class='row mr-15 ml-15 upload_by_footer'> <div class='col-sm-4 col-4'> <p>ID : " + dr["id"].ToString() + "</p> </div> <div class='col-sm-4 text-sm-center text-right col-8'> <p>Upload by : jeenit patel</p> </div> <div class='col-sm-4 text-sm-right text-center col-12'> <p>Date and Time: " + dr["datetime"].ToString() + " </p> </div> </div>";
            //}
            //dr.Close();
            //con.Close();
        }
        try
        {
            //username = 

           
        }
        catch
        {
            Response.Redirect("index.aspx");
        }
    }
}