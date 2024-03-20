using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class task_employee_details : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string id1;
    public string emp;
    public string d,imgmedical="", imgtradevali="", imgadharcard="", imgpass="", imgpan="", imgjoin="", imgsupv="", imgmemo="",imagvis="";
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
    public string ispdf(string path,ref string download)
    {
        string finalpath = "",ext="";
    //    Response.Write("<script>alert('path: " + path + "')</script>");
        if (path.Length > 1)
            ext = path.Substring(path.IndexOf("."));
        else
            ext = "0";
      //  Response.Write("<script>alert('path: "+path+"ext : " + ext + "')</script>");
     
        if (ext == ".jpeg" || ext == ".png" || ext == ".jpg" || ext == ".gif")
        {
            finalpath = path;
            download = path;
        }
        else if (path == "0")
        {
            finalpath = "/imagenotavailable.png";
       download="#";
        }
        else
        {
            finalpath = "/docimg.png";
            download=path;
        }

         return finalpath;
    
    }
    protected void Page_Load(object sender, EventArgs e)
    {



      

        //try
        //    { 
        
            id1 = Request.QueryString["id"].ToString();

            if (Request.QueryString["id"].ToString() != null)
            {

                String role = Request.Cookies["role"].Value.ToString();
               
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from employee where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id1);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                if (role == "user")
                {
                    imagvis = "display:none";
                }
                else
                {
                    imagvis = "";
                }

              

                    while (dr.Read())
                    {


                        string dmedical = "", dtradevali = "", dadgarcard = "", dpass = "", dpan = "", djoin = "", dsupv = "", dmemo = "";
                      
                     
                            imgmedical = dr["madicalcerti"].ToString();

                            imgtradevali = dr["tradevalidation"].ToString();
                          
                            imgadharcard = dr["adharcard"].ToString();
                           
                            imgpass = dr["passport"].ToString();
                            imgpan = dr["pancard"].ToString();
                            imgjoin = dr["joiningdocument"].ToString();
                            imgsupv = dr["supervisorylicence"].ToString();
                            imgmemo = dr["memo"].ToString();



                            //if (imgmedical == "0")
                            //{
                            //    imgmedical = "/imagenotavailable.png";
                            //}
                            //if (imgtradevali == "0")
                            //{
                            //    imgtradevali = "/imagenotavailable.png";
                            //}
                            //if (imgadharcard == "0")
                            //{

                            //    imgadharcard = "/imagenotavailable.png";
                            //}
                            //if (imgpass == "0")
                            //{
                            //    imgpass = "/imagenotavailable.png";
                            //}
                            //if (imgpan == "0")
                            //{
                            //    imgpan = "/imagenotavailable.png";
                            //}

                            //if (imgjoin == "0")
                            //{
                            //    imgjoin = "/imagenotavailable.png";
                            //}
                            //if (imgsupv == "0")
                            //{
                            //    imgsupv = "/imagenotavailable.png";
                            //}
                            //if (imgmemo == "0")
                            //{
                            //    imgmemo = "/imagenotavailable.png";
                            //}

                            imgmedical = ispdf(imgmedical,ref dmedical);
                            imgtradevali = ispdf(imgtradevali,ref dtradevali);
                            imgadharcard = ispdf(imgadharcard,ref dadgarcard);
                            imgpass = ispdf(imgpass,ref dpass);
                            imgpan = ispdf(imgpan,ref dpan);
                            imgjoin = ispdf(imgjoin,ref djoin);
                            imgsupv = ispdf(imgsupv,ref dsupv);
                            imgmemo = ispdf(imgmemo,ref dmemo);


                       
                        //emp = emp + "<div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgmedical + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgmedical + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgtradevali + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgtradevali + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgadharcard + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgadharcard + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgpass + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgpass + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgpan + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgpan + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgjoin + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgjoin + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> </div> <div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgsupv + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgsupv + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgmemo + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgmemo + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> </div>";
                            emp = emp + "<div class='bg-image bg-image-bottom mt-15 mr-15 ml-15' style='background-image:linear-gradient(135deg,#d262e3 0,#3f9ce8 100%);'> <div class='content content-full text-center pb-1'> <div class='mb-15'> <div class='img-link'> <img class='img-avatar img-avatar96 img-avatar-thumb' src='" + dr["photo"].ToString() + "' alt=''> </div> </div> <h1 class='h3 text-white font-w700 mb-10'>" + dr["fname"].ToString() + " " + dr["lname"].ToString() + "<small class=' text-white'> (" + dr["gender"].ToString() + ") </small></h1> <div class='row'> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'>UAN No : " + dr["uanno"].ToString() + "</h2> </div> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'>" + dr["department"].ToString() + " : (" + dr["designation"].ToString() + ")</h2> </div> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'>ESIC No : " + dr["esicno"].ToString() + "</h2> </div> </div> </div> </div> <div class='row ml-0 mr-0 mt-15 detail_page'> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Personal Info</h3> </div> <div class='block-content'> <p><strong> Marital Status :</strong> " + dr["maritalstatus"].ToString() + "</br><strong> Mother's Name :</strong> " + dr["mothername"].ToString() + "<br> <strong>Weight :</strong> " + dr["weight"].ToString() + " <strong class='float-right'>Height : <span class='font-weight-normal'>" + dr["height"].ToString() + "</span></strong> <br> <strong>Blood Group :</strong> " + dr["bloodgroup"].ToString() + "<strong class='float-right'>No. of Children : <span class='font-weight-normal'>" + dr["noofchildren"].ToString() + "</span></strong> <br> <strong>Id Mark :</strong> " + dr["idmark"].ToString() + "<br> <strong> Nearest Police Station : </strong> " + dr["policestation"].ToString() + " <br> Remark : <span class='font-weight-normal'>" + dr["remark"].ToString() + "</span></p> <address class='detail_personal'><i class='fa fa-map-marker' aria-hidden='true'></i> <p class='address_div'>" + dr["address"].ToString() + " " + dr["city"].ToString() + " - " + dr["pincode"].ToString() + " <br>" + dr["state"].ToString() + ", " + dr["country"].ToString() + " </p> <i class='fa fa-phone mr-5'></i>" + dr["mobileno"].ToString() + "<br> <i class='fa fa-phone mr-5'></i>" + dr["emergencyno"].ToString() + " (Emergency)<br> <i class='fa fa-envelope-o mr-5'></i> <a href='javascript:void(0)'>" + dr["email"].ToString() + "</a> </address> </div> </div> </div> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Education Info</h3> </div> <div class='block-content'> <address> <div class='font-size-lg text-black mb-5'>Qualification</div> <strong>Degree : </strong>" + dr["qualification"].ToString() + "<br> <strong>Year : </strong>" + dr["passingyear"].ToString() + "<br> <strong>Percentage : </strong>" + dr["persentage"].ToString() + " %<br> </address> <address> <div class='font-size-lg text-black mb-5'>Experience</div> <strong>Company Name : </strong>" + dr["expicompanyname"].ToString() + "<br> <strong>Duration : </strong>" + dr["expiduration"].ToString() + "<br> <strong>Designation : </strong>" + dr["expidesignation"].ToString() + "<br> </address><strong>Total Experience : " + dr["totalexperience"].ToString() + "</strong> </div> </div> </div> <div class='col-md-4 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Bank Info</h3> </div> <div class='block-content'> <address><strong>Bank Name : </strong>" + dr["bankname"].ToString() + "<br> <strong><strong>Bank Branch Name : </strong>" + dr["bankbranch"].ToString() + "<br> <strong>A/c No : </strong>" + dr["accountno"].ToString() + "<br> <strong>IFSC No : </strong>" + dr["ifsccode"].ToString() + "<br><strong>PF No : </strong>" + dr["pfnumber"].ToString() + " </address> </div> </div> </div> </div> <div class='row mr-15 ml-15 upload_by_footer' style='" + imagvis + "'> <div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgmedical + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Medical Certificate</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dmedical + "' > <i class='fa fa-search-plus'></i>View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dmedical + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgtradevali + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Trade validation </h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dtradevali + "' > <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dtradevali + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgadharcard + "' alt='image not found' > <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Adharcard</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dadgarcard + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dadgarcard + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgpass + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Passport</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dpass + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dpass + "' download=" + id1 + "><i class='fa fa-download'></i>Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgpan + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Pancard</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dpan + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dpass + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgjoin + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Joining Docs</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + djoin + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + djoin + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> </div> <div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-3 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgsupv + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Supervisory Licence</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dsupv + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dsupv + "' download=" + id1 + "><i class='fa fa-download'></i> Download</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-3 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src='" + imgmemo + "' alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Memo</h3> <h4 class='h6 text-white-op mb-15'></h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href='" + dmemo + "'> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='" + dmemo + "' download=" + id1 + "><i class='fa fa-download'></i>Download</a> </div> </div> </div> </div> </div></div> <div class='col-sm-6 text-sm-right text-center col-12'> <p style='" + imagvis + "'></p> </div> </div> <div class='row mt-15 mr-15 ml-15 upload_by_footer'> <div class='col-sm-4 col-4'> <p>ID:" + dr["id"].ToString() + "</p> </div> <div class='col-sm-4 text-sm-center text-right col-8'> <p>Upload by:" + dr["uploadby"].ToString() + "</p> </div> <div class='col-sm-4 text-sm-right text-center col-12'> <p>Date & Time:" + dr["datetime"].ToString() + "</p> </div> </div>";
                    }
                   
               
                dr.Close();


                con.Close();
            }
            try { 
            }
        catch
        {
            Response.Redirect("view.aspx");
        }
    }
}