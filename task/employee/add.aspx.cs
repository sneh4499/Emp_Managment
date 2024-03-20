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
public partial class task_employee_add : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    public string id1;
    public string male1, female, gen1 = "", img = "", imgadharcard = "", imgpassport = "", imgpancard = "", imgjoindoc = "", imgsupervi = "", imgmemo="";
    public string imgcertificatemedical = "", imgtradevali="";
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


        fpimg.Attributes["onchange"] = "UploadFile(this)";
        fpadharcard.Attributes["onchange"] = "UploadFile(this)";
    
        fppancard.Attributes["onchange"] = "UploadFile(this)";
        fpjoindoc.Attributes["onchange"] = "UploadFile(this)";
      
        btnupdate.Visible = false;
        update.Visible = false;


         if (!IsPostBack)
                {
                    try
                    {

                   
                        id1 = Request.QueryString["id"].ToString();
                       
                        if (Request.QueryString["id"].ToString() != null)
                        {
                            con.Open();
                            cmd = new SqlCommand("select * from employee where id=@id", con);
                            cmd.Parameters.AddWithValue("@id", id1);
                            SqlDataReader dr = cmd.ExecuteReader();
                            dr.Read();

                            //txttitle.Text = (dr["photo"].ToString());
                            txtfname.Text = (dr["fname"].ToString());
                            txtlname.Text = (dr["lname"].ToString());
                            txtmothername.Text = (dr["mothername"].ToString());
                        
                          dropdepartment.SelectedItem.Text = (dr["department"].ToString());
                           dropsubdept.SelectedItem.Text = (dr["subdept"].ToString());
                            txtdesignation.Text = (dr["designation"].ToString());
                            txtpassword.Text = (dr["password"].ToString());
                            txtemail.Text = (dr["email"].ToString());
                            txtnumber.Text = (dr["mobileno"].ToString());
                            txtemergencyno.Text = (dr["emergencyno"].ToString());
                          // rdbtngender.SelectedItem.Text = (dr["gender"].ToString());
                            txtweight.Text = (dr["weight"].ToString());
                            txtheight.Text = (dr["height"].ToString());
                            txtbloodgroup.Text = (dr["bloodgroup"].ToString());
                           
                            txtaddress.Text = (dr["address"].ToString());
                            txtpincode.Text = (dr["pincode"].ToString());
                            txtcity.Text = (dr["city"].ToString());
                            txtstate.Text = (dr["state"].ToString());
                            txtcountry.Text = (dr["country"].ToString());
                            //medicalcerti.FileName = (dr["madicalcerti"].ToString());
                            //tradevalidation.FileName = (dr["tradevalidation"].ToString());
                            txtremark.Text = (dr["remark"].ToString());
                            txtqualification.Text = (dr["qualification"].ToString());
                            txtpassingyear.Text = (dr["passingyear"].ToString());
                            txtqualifipersentage.Text = (dr["persentage"].ToString());
                            txtexpicompanyname.Text = (dr["expicompanyname"].ToString());
                            txtexpidesignation.Text = (dr["expidesignation"].ToString());
                            txtexpiduration.Text = (dr["expiduration"].ToString());


                            txtbankname.Text = (dr["bankname"].ToString());
                            txtbankacno.Text = (dr["accountno"].ToString());
                            txtbankifscno.Text = (dr["ifsccode"].ToString());

                            txtfathername.Text = dr["fathername"].ToString();
                            txtmaritalstatus.Text = dr["maritalstatus"].ToString();
                            txttotalexperiance.Text = dr["totalexperience"].ToString();
                            txtbankbranchname.Text = dr["bankbranch"].ToString();
                            txtpassword.Text = dr["password"].ToString();
							txtpfno.Text=dr["pfnumber"].ToString();
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



    protected void btnsave_Click1(object sender, EventArgs e)
    {
        //string file1 = Page.Request.Form["image1"].ToString();
        //Response.Write("<script>('" + file1 + "')</script>");
        // gen1 = Request.QueryString["s"].ToString();
        try
        {
            string Document_Path = Server.MapPath("~/data/" + Path.GetFileName(fpimg.FileName));
            fpimg.SaveAs(Document_Path);

            img = "/data/" + Path.GetFileName(fpimg.FileName);

        }
        catch
        {
            img = "0";
        }

        try
        {
            string Document_Path1 = Server.MapPath("~/data/" + Path.GetFileName(fpadharcard.FileName));
            fpadharcard.SaveAs(Document_Path1);

            imgadharcard = "/data/" + Path.GetFileName(fpadharcard.FileName);

        }
        catch
        {
            imgadharcard = "0";
        }
      
        try
        {
            string Document_Path3 = Server.MapPath("~/data/" + Path.GetFileName(fppancard.FileName));
            fppancard.SaveAs(Document_Path3);

            imgpancard = "/data/" + Path.GetFileName(fppancard.FileName);


        }
        catch
        {
            imgpancard = "0";
        }
        try
        {
            string Document_Path4 = Server.MapPath("~/data/" + Path.GetFileName(fpjoindoc.FileName));
            fpjoindoc.SaveAs(Document_Path4);

            imgjoindoc = "/data/" + Path.GetFileName(fpjoindoc.FileName);
        }
        catch
        {
            imgjoindoc = "0";
        }
       
       
        try
        {
            string Document_Path7 = Server.MapPath("~/data/" + Path.GetFileName(fpmedicalcerti.FileName));
            fpmedicalcerti.SaveAs(Document_Path7);

            imgcertificatemedical = "/data/" + Path.GetFileName(fpmedicalcerti.FileName);

        }
        catch
        {
            imgcertificatemedical = "0";
        }
      

      //  expel.insert("employee", DateTime.Now.ToString(), img, txtfname.Text, txtlname.Text, txtmothername.Text, txtuanno.Text, txtesicno.Text, dropdepartment.SelectedItem.Text, dropsubdept.SelectedItem.Text, txtdesignation.Text, txtdesignation.Text, txtpassword.Text, txtemail.Text, txtnumber.Text, txtemergencyno.Text, rdbtngender.SelectedItem.Text, txtweight.Text, txtheight.Text, txtbloodgroup.Text, txtnoofchildren.Text, txtidmark.Text, txtpolicestation.Text, txtaddress.Text, txtpincode.Text, txtcity.Text, txtstate.Text, txtcountry.Text, imgcertificatemedical, imgtradevali, txtremark.Text, txtqualification.Text, txtpassingyear.Text, txtqualifipersentage.Text, txtexpicompanyname.Text, txtexpidesignation.Text, txtexpiduration.Text, txtbankname.Text, txtbankacno.Text, txtbankifscno.Text, Request.Cookies["email"].Value.ToString(), txtfathername.Text, imgadharcard, imgpassport, imgpancard, imgjoindoc, imgsupervi, imgmemo, txtpfno.Text);

        con.Open();
        cmd = new SqlCommand("insert into employee(datetime,photo,fname,lname,mothername,department,subdept,designation,password,email,mobileno,emergencyno,gender,weight,height,bloodgroup,address,pincode,city,state,country,madicalcerti,remark,qualification,passingyear,persentage,expicompanyname,expidesignation,expiduration,bankname,accountno,ifsccode,uploadby,fathername,adharcard,pancard,joiningdocument,pfnumber,maritalstatus,totalexperience,bankbranch) values (@datetime,@photo,@fname,@lname,@mothername,@department,@subdept,@designation,@password,@email,@mobileno,@emergencyno,@gender,@weight,@height,@bloodgroup,@address,@pincode,@city,@state,@country,@madicalcerti,@remark,@qualification,@passingyear,@persentage,@expicompanyname,@expidesignation,@expiduration,@bankname,@accountno,@ifsccode,@uploadby,@fathername,@adharcard,@pancard,@joiningdocument,@pfnumber,@maritalstatus,@totalexperience,@bankbranch)", con);
        cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
       // string file1 = fileup.Text;
        // Response.Write("<script>alert('" + file1 + "')</script>");
        cmd.Parameters.AddWithValue("@photo", img);
        cmd.Parameters.AddWithValue("@fname", txtfname.Text);
        cmd.Parameters.AddWithValue("@lname", txtlname.Text);
        cmd.Parameters.AddWithValue("@mothername", txtmothername.Text);
       
        cmd.Parameters.AddWithValue("@department", dropdepartment.Text);
        cmd.Parameters.AddWithValue("@subdept", dropdepartment.Text);
        cmd.Parameters.AddWithValue("@designation", txtdesignation.Text);
        cmd.Parameters.AddWithValue("@password", txtpassword.Text);
        cmd.Parameters.AddWithValue("@email", txtemail.Text);
        cmd.Parameters.AddWithValue("@mobileno", txtnumber.Text);
        cmd.Parameters.AddWithValue("@emergencyno", txtemergencyno.Text);

        cmd.Parameters.AddWithValue("@gender", rdbtngender.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@weight", txtweight.Text);
        cmd.Parameters.AddWithValue("@height", txtheight.Text);
        cmd.Parameters.AddWithValue("@bloodgroup", txtbloodgroup.Text);
        
        cmd.Parameters.AddWithValue("@address", txtaddress.Text);
        cmd.Parameters.AddWithValue("@pincode", txtpincode.Text);
        cmd.Parameters.AddWithValue("@city", txtcity.Text);
        cmd.Parameters.AddWithValue("@state", txtstate.Text);
        cmd.Parameters.AddWithValue("@country", txtcountry.Text);
        cmd.Parameters.AddWithValue("@madicalcerti", imgcertificatemedical);
        cmd.Parameters.AddWithValue("@tradevalidation", imgtradevali);
        cmd.Parameters.AddWithValue("@remark", txtremark.Text);
        cmd.Parameters.AddWithValue("@qualification", txtqualification.Text);
        cmd.Parameters.AddWithValue("@passingyear", txtpassingyear.Text);
        cmd.Parameters.AddWithValue("@persentage", txtqualifipersentage.Text);
        cmd.Parameters.AddWithValue("@expicompanyname", txtexpicompanyname.Text);
        cmd.Parameters.AddWithValue("@expidesignation", txtexpidesignation.Text);
        cmd.Parameters.AddWithValue("@expiduration", txtexpiduration.Text);


        cmd.Parameters.AddWithValue("@bankname", txtbankname.Text);
        cmd.Parameters.AddWithValue("@accountno", txtbankacno.Text);
        cmd.Parameters.AddWithValue("@ifsccode", txtbankifscno.Text);

        cmd.Parameters.AddWithValue("@uploadby", Request.Cookies["email"].Value.ToString());
        cmd.Parameters.AddWithValue("@fathername", txtfathername.Text);
        cmd.Parameters.AddWithValue("@adharcard", imgadharcard);
     
        cmd.Parameters.AddWithValue("@pancard", imgpancard);
        cmd.Parameters.AddWithValue("@joiningdocument", imgjoindoc);
       
      
        cmd.Parameters.AddWithValue("@pfnumber", txtpfno.Text);
        cmd.Parameters.AddWithValue("@maritalstatus", txtmaritalstatus.Text);
        cmd.Parameters.AddWithValue("@totalexperience", txttotalexperiance.Text);
        cmd.Parameters.AddWithValue("@bankbranch", txtbankbranchname.Text);

        cmd.ExecuteNonQuery();

        con.Close();
        expel.insert("login", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), txtfname.Text + " " + txtlname.Text, img, drdrole.SelectedItem.Text, txtemail.Text, txtpassword.Text);
        
    
        Response.Redirect("view.aspx");





        txtpassword.Text = "";

        txtfname.Text = "";
        txtlname.Text = "";
        txtmothername.Text = "";
        txtaddress.Text = "";
        txtnumber.Text = "";
       
        txtemail.Text = "";
        txtdesignation.Text = "";
        txtemergencyno.Text = "";
        txtweight.Text = "";
        txtheight.Text = "";
        txtbloodgroup.Text = "";
      
        txtremark.Text = "";
        txtpincode.Text = "";
        txtcity.Text = "";
        txtstate.Text = "";
        txtcountry.Text = "";
        txtqualification.Text = "";
        txtpassingyear.Text = "";
        txtqualifipersentage.Text = "";
        txtexpiduration.Text = "";
        txtexpidesignation.Text = "";
        txtexpicompanyname.Text = "";

        txtbankname.Text = "";
        txtbankacno.Text = "";
        txtbankifscno.Text = "";
        txtmaritalstatus.Text = "";
        txttotalexperiance.Text = "";
        txtbankbranchname.Text = "";
     


        
        
    }

    protected void btnupdate_Click1(object sender, EventArgs e)
    {


        

                    id1 = Request.QueryString["id"].ToString();

                   
                        if (fpimg.HasFile)
                        {

                            string Document_Path = Server.MapPath("~/data/" + Path.GetFileName(fpimg.FileName));
                            fpimg.SaveAs(Document_Path);
                            img = "/data/" + Path.GetFileName(fpimg.FileName);
                            con.Open();
                            cmd = new SqlCommand("update employee set photo=@photo where id=@id", con);
                            cmd.Parameters.AddWithValue("@id", id1);
                            cmd.Parameters.AddWithValue("@photo", img);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        
                    
         if (fpadharcard.HasFile)
                    {
                        string Document_Path1 = Server.MapPath("~/data/" + Path.GetFileName(fpadharcard.FileName));
                        fpadharcard.SaveAs(Document_Path1);
                        img = "/data/" + Path.GetFileName(fpadharcard.FileName);
                        con.Open();
                        cmd = new SqlCommand("update employee set adharcard=@adharcard where id=@id", con);
                        cmd.Parameters.AddWithValue("@id", id1);
                        cmd.Parameters.AddWithValue("@adharcard", img);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
      



        if (fppancard.HasFile)
                    {
                    string Document_Path3 = Server.MapPath("~/data/" + Path.GetFileName(fppancard.FileName));
                    fppancard.SaveAs(Document_Path3);
                    imgpancard = "/data/" + Path.GetFileName(fppancard.FileName);
                    con.Open();
                    cmd = new SqlCommand("update employee set pancard=@pancard where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id1);
                    cmd.Parameters.AddWithValue("@pancard", imgpancard);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    }
       

        if (fpjoindoc.HasFile)
                    {
                    string Document_Path4 = Server.MapPath("~/data/" + Path.GetFileName(fpjoindoc.FileName));
                    fpjoindoc.SaveAs(Document_Path4);
                    imgjoindoc = "/data/" + Path.GetFileName(fpjoindoc.FileName);
                    con.Open();
                    cmd = new SqlCommand("update employee set joiningdocument=@joiningdocument where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id1);
                    cmd.Parameters.AddWithValue("@joiningdocument", imgjoindoc);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   }


      
        if (fpmedicalcerti.HasFile)
        {
            string Document_Path7 = Server.MapPath("~/data/" + Path.GetFileName(fpmedicalcerti.FileName));
            fpmedicalcerti.SaveAs(Document_Path7);
            imgcertificatemedical = "/data/" + Path.GetFileName(fpmedicalcerti.FileName);
            con.Open();
            cmd = new SqlCommand("update employee set madicalcerti=@madicalcerti where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id1);
            cmd.Parameters.AddWithValue("@madicalcerti", imgcertificatemedical);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       

                    con.Open();
                    cmd = new SqlCommand("update employee set fname=@fname,lname=@lname,mothername=@mothername,designation=@designation,password=@password,mobileno=@mobileno,emergencyno=@emergencyno,weight=@weight,height=@height,bloodgroup=@bloodgroup,address=@address,pincode=@pincode,city=@city,state=@state,country=@country,remark=@remark,qualification=@qualification,passingyear=@passingyear,persentage=@persentage,expicompanyname=@expicompanyname,expidesignation=@expidesignation,expiduration=@expiduration,bankname=@bankname,accountno=@accountno,ifsccode=@ifsccode,uploadby=@uploadby,fathername=@fathername,pfnumber=@pfnumber,maritalstatus=@maritalstatus,totalexperience=@totalexperience,bankbranch=@bankbranch where id=@id", con);

//        cmd = new SqlCommand("update employee set fname=@fname,lname=@lname,mothername=@mothername,uanno=@uanno,esicno=@esicno,designation=@designation,email=@email,mobileno=@mobileno,emergencyno=@emergencyno,weight=@weight,height=@height,bloodgroup=@bloodgroup,noofchildren=@noofchildren,idmark=@idmark,policestation=@policestation,address=@address,pincode=@pincode,city=@city,state=@state,country=@country,madicalcerti=@madicalcerti,tradevalidation=@tradevalidation,remark=@remark,qualification=@qualification,passingyear=@passingyear,persentage=@persentage,expicompanyname=@expicompanyname,expidesignation=@expidesignation,expiduration=@expiduration,bankname=@bankname,accountno=@accountno,ifsccode=@ifsccode,uploadby=@uploadby,fathername=@fathername,adharcard=@adharcard,passport=@passport,pancard=@pancard,joiningdocument=@joiningdocument,supervisorylicence=@supervisorylicence,memo=@memo,pfnumber=@pfnumber where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id1);
                    cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                    cmd.Parameters.AddWithValue("@mothername", txtmothername.Text);
                 
                   cmd.Parameters.AddWithValue("@department", dropdepartment.SelectedItem.Text);
                   cmd.Parameters.AddWithValue("@subdept", dropsubdept.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@designation", txtdesignation.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                   // cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@mobileno", txtnumber.Text);
                    cmd.Parameters.AddWithValue("@emergencyno", txtemergencyno.Text);
                   // cmd.Parameters.AddWithValue("@gender", rdbtngender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@weight", txtweight.Text);
                    cmd.Parameters.AddWithValue("@height", txtheight.Text);
                    cmd.Parameters.AddWithValue("@bloodgroup", txtbloodgroup.Text);
                    
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@pincode", txtpincode.Text);
                    cmd.Parameters.AddWithValue("@city", txtcity.Text);
                    cmd.Parameters.AddWithValue("@state", txtstate.Text);
                    cmd.Parameters.AddWithValue("@country", txtcountry.Text);
                    cmd.Parameters.AddWithValue("@madicalcerti", imgcertificatemedical);
                  
                    cmd.Parameters.AddWithValue("@remark", txtremark.Text);
                    cmd.Parameters.AddWithValue("@qualification", txtqualification.Text);
                    cmd.Parameters.AddWithValue("@passingyear", txtpassingyear.Text);
                    cmd.Parameters.AddWithValue("@persentage", txtqualifipersentage.Text);
                    cmd.Parameters.AddWithValue("@expicompanyname", txtexpicompanyname.Text);
                    cmd.Parameters.AddWithValue("@expidesignation", txtexpidesignation.Text);
                    cmd.Parameters.AddWithValue("@expiduration", txtexpiduration.Text);
                   
                 
                    cmd.Parameters.AddWithValue("@bankname", txtbankname.Text);
                    cmd.Parameters.AddWithValue("@accountno", txtbankacno.Text);
                    cmd.Parameters.AddWithValue("@ifsccode", txtbankifscno.Text);
                    cmd.Parameters.AddWithValue("@uploadby", Request.Cookies["email"].Value.ToString());
                    // cmd.Parameters.AddWithValue("@uploadby", Request.Cookies["email"].Value.ToString());
                    cmd.Parameters.AddWithValue("@fathername", txtfathername.Text);
                    cmd.Parameters.AddWithValue("@adharcard", imgadharcard);
                   
                    cmd.Parameters.AddWithValue("@pancard", imgpancard);
                    cmd.Parameters.AddWithValue("@joiningdocument", imgjoindoc);
                 
                  
                    cmd.Parameters.AddWithValue("@pfnumber", txtpfno.Text);
                    cmd.Parameters.AddWithValue("@maritalstatus", txtmaritalstatus.Text);
                    cmd.Parameters.AddWithValue("@totalexperience", txttotalexperiance.Text);
                    cmd.Parameters.AddWithValue("@bankbranch", txtbankbranchname.Text);
       
                    cmd.ExecuteNonQuery();


                    ///string lid = expel.getSingleData("select id from login where email like '"+txtemail.Text+"'");
                    SqlCommand cmd1111 = new SqlCommand("update login set password='"+txtpassword.Text+"' where email='"+txtemail.Text+"'",con);
                    cmd1111.ExecuteNonQuery();

                    con.Close();

                
       
        Response.Redirect("view.aspx");
    }
   
}