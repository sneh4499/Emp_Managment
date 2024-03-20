<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jcfp.aspx.cs" Inherits="task_jcf_jcfp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
       
    </style>
   <!-- Required meta tags -->
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1, maximum-scale=1" />
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
     <div class="container-fluid form_2">
        <div class="paper_page border-2">
            <div class="logo_sec">
               
                <div class="form_no ">
                    <h1 class="mb-5"><b class="ml-5"><i class="ml-5 pl-5"><img src="../jcfassests/expel-logo.png" style="width:400px" /></i><span
                                class="float-right mr-5 pr-4">J C F</span> </b></h1>
                    <p class="float-left">JOB CODE: <%=jobs %></p>
                    
                    <p class="float-right">JOB COMPLETION FORM</p>
                </div>
            </div>
            <div class="border-1 tabel_form m-2 mb-4">
                <div class="sec_1">
                    <div class="row">
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>JIF NO.</p>
                        </div>
                        <div class="col-10 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp&nbsp <%=jifno %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>CLIENT NAME</p>
                        </div>
                        <div class="col-10 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp&nbsp&nbsp <%=clientname %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>ADDRESS</p>
                        </div>
                        <div class="col-10 p-0">
                            <p class="border-b pb-31 "> &nbsp&nbsp&nbsp&nbsp <%=address %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>JOB DETAILS</p>
                        </div>
                        <div class="col-10 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp&nbsp&nbsp <%=jobdetail %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>NAME OF SITE IN CHARGE</p>
                        </div>
                        <div class="col-10 p-0 border-b">
                            <p class=" pb-31 ">&nbsp&nbsp&nbsp&nbsp <%=teamleader %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>JOB START DATE</p>
                        </div>
                        <div class="col-4 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp&nbsp <%=frm %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r border-b">
                            <p>JOB FINISHED DATE</p>
                        </div>
                        <div class="col-4 p-0">
                            <p class="border-b pb-31 ">&nbsp&nbsp <%=jobfinished %></p>
                        </div>

                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>JOB STATUS</p>
                        </div>
                        <div class="col-3 ">
                            <p class="pl-2 "><%--<span class="pr-2 border-r mr-2"></span>--%><%=remarksforjob %></p>
                         <%--   <p class="pl-2"><span class="pr-2 border-r mr-2">&#10063;</span>Not Completed</p>--%>
                        </div>
                        <div class="col-3 "> <%--border-r p-0"--%>
                            <%--<p class="pl-2 border-b"><span class="pr-2 border-r mr-2">&#10063;</span>Second Visit
                                required</p>
                            <p class="pl-2"><span class="pr-2 border-r mr-2">&#10063;</span>No Job requirement</p>--%>
                        </div>
                        <div class="col-4 ">
                            <%--<p class="pl-2 border-b"><span class="pr-2 border-r mr-2">&#10063;</span>Material / Tools
                                Required</p>
                            <p class="pl-2"><span class="pr-2 border-r mr-2">&#10063;</span>Other
                                <span class="ml-2">&#10063;</span>
                            </p>--%>
                        </div>

                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>REASON IF NOT COMPLETED</p>
                        </div>
                        <div class="col-10 vertical_middel border-t border-b pt-3 pb-3">
                            <p class="pt-2 pb-2">&nbsp&nbsp&nbsp&nbsp <%=reson %></p>
                        </div>

                        <div class="col-2 vertical_middel border-r border-b">
                            <p>TEAM MEMBERS</p>
                        </div>
                         <div class="col-10  border-t border-b pt-3 pb-3">
                            <p class="pt-2 pb-2">&nbsp&nbsp&nbsp&nbsp <%=colleagenames %></p>
                        </div>
                       <%-- <div class="col-3 ">
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">1</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">2</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">3</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">4</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">5</p>
                        </div>
                        <div class="col-3  border-r p-0">
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">6</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">7</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">8</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">9</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">10</p>
                        </div>
                        <div class="col-4  p-0">
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">11</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">12</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">13</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">14</p>
                            <p class="text_justify_left border-b pb-12 pl-2 vertical_middel">15</p>
                        </div>--%>
                        <%=data %>
                        <%--<div class="tabel_div w-100">
                            <table class="w-100 border-b">
                                <tr>
                                    <th>SR NO.</th>
                                    <th>JOB COMPLETION DETAAILS</th>
                                    <th>TO WHOME</th>
                                    <th>YES/NO/NA</th>
                                </tr>
                                <tr>
                                    <td>1</td>
                                    <td>MOM Prepared, signed by client & submitted?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Time Sheet signed with Travelling Date?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>3</td>
                                    <td>Work Done report submitted with MOM</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>4</td>
                                    <td>Test Report filled & arranged as per substation & switch board</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>5</td>
                                    <td>All remarks on test reports mentioned clearly</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>6</td>
                                    <td>All tools/ laptop / accessories brought back, given to service center?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>7</td>
                                    <td>Any document / manual taken from office given back?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>8</td>
                                    <td>Any damage / missing equipment informed to office & service center?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>9</td>
                                    <td>Any problem to / from / with client is informed to office?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>10</td>
                                    <td>If material is delivered gate pass is submitted to office?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>11</td>
                                    <td>DIGSI project back up per visit is taken & saved in office?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>12</td>
                                    <td>Expense sheet filled up & submitted to office?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>13</td>
                                    <td>D A of colleagues given & no pending</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>14</td>
                                    <td>Balance amount given back to office & taken balance from office?</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </div>--%>
                    </div>
                    <div class="row">
                        <div class="col-2 vertical_middel border-r border-b ">
                            <p>JOB<br>COMPLETED</p>
                        </div>
                        <div class="col-3  border-r border-b p-0">
                            <p class="pl-2 border-b">Passed By</p>
                            <p class="pl-2 pt-4 pb-1">Sign<br>Name : <%=teamleader %></p>
                        </div>
                        <div class="col-3  border-r border-b p-0">
                            <p class="pl-2 border-b">Manager / Site coordinator</p>
                            <p class="pl-2 pt-4 ">Sign<br>Name </p>
                        </div>
                        <div class="col-4  border-b p-0">
                            <p class="pl-2 border-b">Team Leader</p>
                            <p class="pl-2 pt-4 ">Sign<br>Name : <%=teamleader %></p>
                        </div>
                        <div class="col-2 vertical_middel border-r pt-3 pb-3  ">
                            <p>Special<br>Remarks</p>
                        </div>
                        <div class="col-10">
                            <%=specialremark %>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    </div>
    <!-- jQuery js -->
   
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
