<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jifp.aspx.cs" Inherits="task_jcf_jifp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <!-- Required meta tags -->
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=1261px, initial-scale=1.0, minimum-scale=1, maximum-scale=1" />
    <meta charset="UTF-8">
    <!-- Required Title -->
    <title></title>
    <!-- Stylesheets -->
    <!-- Bootstrap 4 css-->
    <link href="../jcfassests/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <!-- Bootstrap 4 select css -->
    <link href="../jcfassests/css/bootstrap-select.min.css" rel="stylesheet" type="text/css" />
    <link href="../jcfassests/css/bootstrap-datepicker.css" rel="stylesheet" type="text/css" />
    <!-- Font Font awesome css -->
    <link href="../jcfassests/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.8.2/css/all.css"
        integrity="sha384-oS3vJWv+0UjzBfQzYUhtDYW+Pj2yciDJxpsK1OYPAYjqT085Qq/1cq5FLXAZQ7Ay" crossorigin="anonymous">
    <!-- OWL Carousel css -->
    <link href="../jcfassests/css/owl.carousel.min.css" rel="stylesheet" type="text/css" />
    <link href="../jcfassests/css/owl.theme.default.min.css" rel="stylesheet" type="text/css" />
    <!-- Animate css -->
    <link href="../jcfassests/css/animate.css" rel="stylesheet" type="text/css" />
    <!-- style css -->
    <link href="../jcfassests/css/style.css" rel="stylesheet" type="text/css" />
    <link href="../jcfassests/css/style.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid">
        <div class="paper_page border-2">
            <div class="logo_sec">
               
                <div class="form_no ">
                        <h1 class="mb-5"><b class="ml-5"><i class="ml-5 pl-5"><img src="../jcfassests/expel-logo.png" style="width:600px" /></i><span class="float-right mr-5 pr-4">J I F</span> </b></h1>
                  
                      
                     
                   

                    <div class="row">
                        <div class="col-md-3"> 
                              <p class="float-left">JOB CODE: <%=jobs %></p>
                        </div>
                         <div class="col-md-6"> <p class="text-center">Reaching Time : <%=reachingtime %> <br /> Reporting Time : <%=reportingtime %></p></div>
                         <div class="col-md-3">
                             <p class="float-right">JOB DATE : <%=frmdate %></p><br />
                              <p class="float-right">JOB INTIMATION FORM</p></div>
                    </div>
                </div>
                
            </div>
            <div class="border-1 tabel_form m-2 mb-4">
                <div class="sec_1">
                    <div class="row">
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>TEAM MEMBERS</p>
                        </div>
                        <div class="col-10 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp RESPONSIBLE PERSON FOR SITE :  <%=teammember %></p>
                           <%-- <p class="border-b pb-31 "></p>--%>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>CLIENT NAME</p>
                        </div>
                        <div class="col-4 p-0">
                          <%--  <p class="border-b pb-31 "></p>--%>
                            <p class="border-b pb-31 ">&nbsp&nbsp  <%=clientname %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b border-l">
                            <p>LOCATION</p>
                        </div>
                        <div class="col-4 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp <%=locationnew %></p>
                         <%--   <p class="border-b pb-31 "></p>--%>
                        </div>
                        <div class="col-2 vertical_middel border-r ">
                            <p>CLIENT ADDRESS</p>
                        </div>
                        <div class="col-4 p-0">
                            <p >&nbsp&nbsp <%=clientaddress %></p>
                           <%-- <p class="border-b pb-31 "></p>
                            <p class="border-b pb-31 "></p>--%>
                        </div>
                        <div class="col-2 vertical_middel border-r border-l">
                            <p>CONTACT PERSON & CONTACT NO.</p>
                        </div>
                        <div class="col-4 p-0 row sub_row">
                            <div class="col-5  border-r border-b">
                                <p>NAME</p>
                            </div>
                            <div class="col-7 p-0">
                                <p class="border-b pb-31 ">&nbsp&nbsp   <%=sitecontactname %></p>
                            </div>
                            <div class="col-5  border-r border-b">
                                <p>CONTACT NO.</p>
                            </div>
                            <div class="col-7 p-0 border-b">
                                <p class=" pb-31 ">&nbsp&nbsp  <%=sitemobile %></p>
                            </div>
                            <div class="col-5  border-r border-b">
                                <p class="">LAND LINE NO.</p>
                            </div>
                            <div class="col-7 p-0 border-b">
                                <p class=" pb-31 ">&nbsp&nbsp <%=sitelandline %></p>
                            </div>
                            <div class="col-3  border-r ">
                                <p>Email ID</p>
                            </div>
                            <div class="col-9 p-0">
                                <p class=" pb-31 ">&nbsp <%=siteemail %></p>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="border-b border-t">
                <div class="sec_2">
                    <div class="row">
                        <div class="col-2 vertical_middel border-r ">
                            <p>JOB <br> THROUGH</p>
                        </div>
                        <div class="col-1 vertical_middel p-0  checkbox_col">
<%--                            <input class="styled-checkbox" id="styled-checkbox-1" type="checkbox" value="value1">--%>
                            <label for="styled-checkbox-1"></label>
                        </div>
                        <div class="col-1 vertical_middel p-0 ">
                            <label for="styled-checkbox-1" ><%=jobthrough %></label>
                        </div>
                        <div class="col-1 vertical_middel p-0  checkbox_col">
                            <%--<input class="styled-checkbox" id="styled-checkbox-2" type="checkbox" value="value1">--%>
                            <label for="styled-checkbox-2"></label>
                        </div>
                        <div class="col-1 vertical_middel p-0 ">
                            <label for="styled-checkbox-2"></label>
                        </div>
                        <div class="col-1 vertical_middel p-0 checkbox_col">
                           <%-- <input class="styled-checkbox" id="styled-checkbox-3" type="checkbox" value="value1">--%>
                            <label for="styled-checkbox-3"></label>
                        </div>
                        <div class="col-2 vertical_middel p-0  custom_2">
                            <label for="styled-checkbox-3"></label>
                        </div>
                        <div class="col-1 vertical_middel p-0  checkbox_col">
                          <%--  <input class="styled-checkbox" id="styled-checkbox-4" type="checkbox" value="value1">--%>
                            <label for="styled-checkbox-4"></label>
                        </div>
                        <div class="col-2 vertical_middel p-0 custom_2">
                            <label for="styled-checkbox-4"></label>
                        </div>
                    </div>
                    <div class="row border-t">
                        <div class="col-2 vertical_middel border-r ">
                            <p>ADDRESS/<br>OFFICE</p>
                        </div>
                        <div class="col-2 ">
                            <p><%=addressoffice %></p>
                        </div>
                        <div class="col-2 border-r ">
                            <p></p>
                        </div>
                       
                        <div class="col-2 vertical_middel">
                            <p>Reason for free service</p>
                        </div>
                          <div class=" border-r ">
                            <p></p>
                        </div>
                         <div class="col-3 vertical_middel">
                            <p><%=reasonforfree %></p>
                        </div>
                    </div>
                    <div class="row border-t mr_column">
                        <div class="col-2 vertical_middel border-r ">
                            <p>CONTACT PERSON</p>
                        </div>
                        <div class="col-1 vertical_middel p-0 border-r checkbox_col">
                            MR.
                        </div>
                        <div class="col-3 vertical_middel border-r custom_3">
                            <p> <%=mr1 %></p>
                        </div>
                        <div class="col-1 vertical_middel p-0 border-r checkbox_col">
                            MR.
                        </div>
                        <div class="col-4 vertical_middel">
                            <p> <%=mr2 %></p>
                        </div>
                    </div>
                    <div class="row border-t mr_column">
                        <div class="col-2 vertical_middel border-r ">
                            <p>CONTACT NO</p>
                        </div>
                        <div class="col-4 row p-0 sub_row">
                            <div class="col-5  border-r border-b">
                                <p>MOBILE NO</p>
                            </div>
                            <div class="col-7 p-0">
                                <p class="border-b pb-31 ">&nbsp&nbsp&nbsp <%=contact1 %></p>
                            </div>
                            <div class="col-5  border-r ">
                                <p>LAND LINE NO</p>
                            </div>
                            <div class="col-7 p-0">
                                <p class=" pb-31 "> &nbsp&nbsp&nbsp<%=landline1 %></p>
                            </div>
                        </div>
                        <div class="col-6 row p-0 sub_row border-l">
                            <div class="col-4  border-r border-b">
                                <p>MOBILE NO</p>
                            </div>
                            <div class="col-8 p-0">
                                <p class="border-b pb-31 ">&nbsp&nbsp&nbsp<%=contact2 %></p>
                            </div>
                            <div class="col-4  border-r ">
                                <p>LAND LINE NO</p>
                            </div>
                            <div class="col-8 p-0">
                                <p class=" pb-31 ">&nbsp&nbsp&nbsp<%=landline1 %></p>
                            </div>
                        </div>
                    </div>
                </div>
                <hr class="border-b border-t">
                <div class="sec_3">
                    <div class="row">
                        <div class="col-2 vertical_middel border-r ">
                            <p>VISIT FOR</p>
                        </div>
                        <div class="col-4   checkbox_col small_checkbox">
                            <%=visitfor %>
                           <%-- <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-5" type="checkbox" value="value1">
                                <label for="styled-checkbox-5">T&C - Relay</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-6" type="checkbox" value="value1">
                                <label for="styled-checkbox-6">T&C - HT PANEl</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-7" type="checkbox" value="value1">
                                <label for="styled-checkbox-7">T&C - LT PANEl</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-8" type="checkbox" value="value1">
                                <label for="styled-checkbox-8">T&C - EHV BKR</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-9" type="checkbox" value="value1">
                                <label for="styled-checkbox-9">ISOLATOR</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-10" type="checkbox" value="value1">
                                <label for="styled-checkbox-10">COMMUNICATION / SCADA</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-11" type="checkbox" value="value1">
                                <label for="styled-checkbox-11">RETROFITTING - RELAY / ACB / VCB</label>
                            </div>--%>
                        </div>
                        <div class="col-3  checkbox_col small_checkbox">
                            <%--<div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-12" type="checkbox" value="value1">
                                <label for="styled-checkbox-12">SERVICING - HT BKR</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-13" type="checkbox" value="value1">
                                <label for="styled-checkbox-13">SERVICING - HT PNL</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-14" type="checkbox" value="value1">
                                <label for="styled-checkbox-14">SERVICING - LT BKR</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-15" type="checkbox" value="value1">
                                <label for="styled-checkbox-15">SERVICING - LT PNL</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-16" type="checkbox" value="value1">
                                <label for="styled-checkbox-16">RELAY TESTING</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-17" type="checkbox" value="value1">
                                <label for="styled-checkbox-17">TR TESTING</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-18" type="checkbox" value="value1">
                                <label for="styled-checkbox-18">CABLE TESTING</label>
                            </div>--%>
                        </div>
                        <div class="col-3  checkbox_col small_checkbox">
                            <%--<div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-19" type="checkbox" value="value1">
                                <label for="styled-checkbox-19">ONE DAY VISIT</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-20" type="checkbox" value="value1">
                                <label for="styled-checkbox-20">FREE VISIT</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-21" type="checkbox" value="value1">
                                <label for="styled-checkbox-21">MATERIAL DELIVERY</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-22" type="checkbox" value="value1">
                                <label for="styled-checkbox-22">JOB DISCUSSION</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-23" type="checkbox" value="value1">
                                <label for="styled-checkbox-23">MARKETING</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-24" type="checkbox" value="value1">
                                <label for="styled-checkbox-24">TRAINING / SEMINAR</label>
                            </div>
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-25" type="checkbox" value="value1">
                                <label for="styled-checkbox-25">SPARES REPLACEMENT</label>
                            </div>--%>
                        </div>
                        <div class="col-2 vertical_middel border-r border-t border-b">
                            <p>ADDITIONAL INFORMATION</p>
                        </div>
                        <div class="col-10 border-t border-b">
                            <p><%=jobdetail %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p >VEHICLE PLANNING</p>
                        </div>
                        <div class="col-6  border-r checkbox_col Vehical_planning border-b">
                            <div class="check_vist">
                               <%-- <input class="styled-checkbox" id="styled-checkbox-26" type="checkbox" value="value1">--%>
                                <label for="styled-checkbox-26">&nbsp;&nbsp;<%=travelby %> : <%=travelto %></label>
                            </div>
                        </div>
                      <%--  <div class="col-3  border-r checkbox_col Vehical_planning border-b">
                            <div class="check_vist">
                                <input class="styled-checkbox" id="styled-checkbox-27" type="checkbox" value="value1">
                                <label for="styled-checkbox-27"><%=travelto %></label>
                            </div>
                        </div>--%>
                        <div class="col-4  checkbox_col Vehical_planning border-b">
                            <div class="check_vist">
                               <%-- <input class="styled-checkbox" id="styled-checkbox-28" type="checkbox" value="value1">--%>
                                <label for="styled-checkbox-28"></label>
                            </div>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>TEST CERTIFICATE</p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b text_justify_left">
                            <p>LIST GIVEN BY :<br> <%=Testcertificate %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b text_justify_left">
                            <p>TESTING EQUIPMENTS </p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b text_justify_left">
                            <p>LIST GIVEN BY :<br><%=Testingequipment %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b text_justify_left">
                            <p>PPE, WC policy, Other required documents taken</p>
                        </div>
                        <div class="col-2  border-b text_justify_left vertical_middel text_justify_bottom">
                         
                             
                               <p><b>Sign of leader</b></p>
                                
                            
                        </div>
                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>ADVANCE FOR SITE EXPENSE</p>
                        </div>
                        <div class="col-3  border-r border-b p-0">
                            <p class="border-b pl-2">Amount: </p>
                            <p class="border-b pl-2">Passed By : <%=passedbyreference %> </p>
                            <p class="pl-2 pt-1 pb-1">Sign<br /><br /><br /> </p>
                        </div>
                        <div class="col-3  border-r border-b p-0">
                            <p class="border-b pl-2">Amount: </p>
                            <p class="border-b pl-2">Name Accounts: </p>
                            <p class="pl-2">Sign </p>
                        </div>
                        <div class="col-4  border-b p-0">
                            <p class="border-b pl-2">Amount : <%=amount %></p>
                            <p class="border-b pl-2">Name Site Person :  <%=teamleader %></p>
                            <p class="pl-2">Sign </p>
                        </div>
                        <div class="col-2 vertical_middel border-r  ">
                            <p>Special Remarks</p>
                        </div>
                        <div class="col-10">
                            <p><%=remarks %></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>




        <script src="../jcfassests/js/jquery.min.js"></script>
    <!-- Bootstrap 4 js -->
    <script src="../jcfassests/js/bootstrap.min.js"></script>
    <script src="../jcfassests/js/bootstrap-datepicker.js"></script>
    <!-- Bootstrap 4 select js -->
    <script src="../jcfassests/js/bootstrap-select.min.js"></script>
    <!-- OWL Carousel js -->
    <script src="../jcfassests/js/owl.carousel.js"></script>
    <!-- Wow js -->
    <script src="../jcfassests/js/wow.js"></script>
    <!-- custom js -->
    <script src="../jcfassests/js/custom.js"></script>
</body>

</html>
