<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="department_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Welcome to Trackingbean</title>

   <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">

       
        <meta name="description" content="Trackingbean">
        <meta name="author" content="pixelcave">
        <meta name="robots" content="noindex, nofollow">

        <!-- Open Graph Meta -->
        <meta property="og:title" content="Trackingbean">
        <meta property="og:site_name" content="Trackingbean">
        <meta property="og:description" content="Trackingbean">
        <meta property="og:type" content="website">
        <meta property="og:url" content="">
        <meta property="og:image" content="">

        <!-- Icons -->
        <!-- The following icons can be replaced with your own, they are used by desktop and mobile browsers -->
        <link rel="shortcut icon" href="../assets/media/favicons/favicon.png">
        <link rel="icon" type="image/png" sizes="192x192" href="../assets/media/favicons/favicon-192x192.png">
        <link rel="apple-touch-icon" sizes="180x180" href="../assets/media/favicons/apple-touch-icon-180x180.png">
        <!-- END Icons -->

        <!-- Stylesheets -->

        <!-- Fonts and Codebase framework -->
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Muli:300,400,400i,600,700" />
        <link rel="stylesheet" href="../assets/css/codebase.min.css">

         <!-- END Stylesheets -->
</head>
<body>
    <form id="form1" runat="server">

    <div id="page-container" class=" main-content-boxed">

            <!-- Main Container -->
            <main id="main-container">
              
                <div class="bg-video" data-vide-bg="assets/media/photos/photo34@2x.jpg" data-vide-options="posterType: jpg">
                    <div class="hero bg-black-op">
                        <div class="hero-inner">
                      
                            <div class="row mx-0 bg-black-op">
                        <div class="hero-static col-md-6 col-xl-8 d-none d-md-flex align-items-md-end">
                            <div class="p-30 invisible" data-toggle="appear">
                                <p class="font-size-h3 font-w600 text-white">
                                  Welcome to Employee Tracking Bean
                                </p>
                                
                            </div>
                        </div>
                        <div class="hero-static col-md-6 col-xl-4 d-flex align-items-center bg-white invisible" data-toggle="appear" data-class="animated fadeInRight">
                            <div class="content content-full">
                                <!-- Header -->
                                <div class="px-30 py-10">
                                    <div >
                                        <img src="../assets/logo.gif" class="img-fluid"/>
                 </div>
                                        <h1 class="h3 font-w700 mt-30 mb-10">Welcome to Your Dashboard</h1>
                                    <h2 class="h5 font-w400 text-muted mb-0">Please sign in</h2>
                                </div>
                                <!-- END Header -->

                                <!-- Sign In Form -->
                                <!-- jQuery Validation functionality is initialized with .js-validation-signin class in js/pages/op_auth_signin.min.js which was auto compiled from _es6/pages/op_auth_signin.js -->
                                <!-- For more examples you can check out https://github.com/jzaefferer/jquery-validation -->
                                <div class="js-validation-signin px-30">
                                    <div class="form-group row">
                                        <div class="col-12">
                                            <div class="form-material floating">
                                                <asp:textbox id="txtusermail" required="" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:textbox>
                                 <label for="wizard-simple2-firstname">User Email</label>
                             </div>
                                        </div>
                                    </div>
                                    <div class="form-group row">
                                        <div class="col-12">
                                            <div class="form-material floating">
                                                <asp:textbox id="txtpassword" required="" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="Password"></asp:textbox>
                                 <label for="wizard-simple2-firstname">Password</label>
                              </div>
                                        </div>
                                    </div>
                                    <div class="form-group row">
                                        <div class="col-12">

                                       
                                            <div >
                                                    <asp:CheckBox ID="chk" runat="server" CssClass="btn btn-circle" />
                                               <%-- <input type="checkbox" class="custom-control-input" id="login-remember-me" name="remember">--%>
                                                <label  >Remember Me</label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Button ID="btnlogin" class="btn btn-sm btn-hero btn-alt-primary" runat="server" Text="Sign In" OnClick="btnlogin_Click"/>
                                       <%-- <button type="submit" class="btn btn-sm btn-hero btn-alt-primary">
                                            <i class="si si-login mr-10"></i> Sign In
                                        </button>--%>
                                        <div class="mt-30">
                                            <a class="link-effect text-muted mr-10 mb-5 d-inline-block" href="forgetpassword.aspx">
                                                <i class="fa fa-warning mr-5"></i> Forgot Password
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <!-- END Sign In Form -->
                            </div>
                        </div>
                    </div>


                        </div>
                    </div>
                </div>

                <!-- Page Content -->
                
             <%--   <div class="bg-image" style="background-image: url('../assets/media/photos/photo34@2x.jpg');">
                    
                </div>--%>
                <!-- END Page Content -->

            </main>
            <!-- END Main Container -->
        </div>
            
    
        </form>


     <script src="../assets/js/codebase.core.min.js"></script>

        <!--
            Codebase JS

            Custom functionality including Blocks/Layout API as well as other vital and optional helpers
            webpack is putting everything together at assets/_es6/main/app.js
        -->
        <script src="../assets/js/codebase.app.min.js"></script>

        <!-- Page JS Plugins -->
        <script src="../assets/js/plugins/jquery-validation/jquery.validate.min.js"></script>

        <!-- Page JS Code -->
        <script src="../assets/js/pages/op_auth_signin.min.js"></script>
    <script src="assets/js/plugins/jquery-vide/jquery.vide.min.js"></script>

   
</body>
</html>
