<%@ Page Language="C#" AutoEventWireup="true" CodeFile="logout.aspx.cs" Inherits="logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">

        <title>Trackingbean</title>

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
        <link rel="shortcut icon" href="assets/media/favicons/favicon.png">
        <link rel="icon" type="image/png" sizes="192x192" href="assets/media/favicons/favicon-192x192.png">
        <link rel="apple-touch-icon" sizes="180x180" href="assets/media/favicons/apple-touch-icon-180x180.png">
        <!-- END Icons -->

        <!-- Stylesheets -->

        <!-- Fonts and Codebase framework -->
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Muli:300,400,400i,600,700">
        <link rel="stylesheet" href="assets/css/codebase.min.css">

        <!-- You can include a specific file from css/themes/ folder to alter the default color theme of the template. eg: -->
        <!-- END Stylesheets -->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="page-container" class="main-content-boxed">

            <!-- Main Container -->
            <main id="main-container">
               
                <!-- Page Content -->
               
                <div class="bg-gd-lake">
                   
                    <div class="hero-static content content-full bg-white invisible" data-toggle="appear">
                        <!-- Header -->
                        <div class="py-30 px-5 text-center">
                           <div>
                                        <img src="../assets/logo.gif" style="height:10%;width:50%" class="img-fluid"/>
                 </div>
                            <h1 class="h2 font-w700 mt-50 mb-10">You're Successfully Signed Out</h1>
                                             
                        </div>
                        <!-- END Header -->

                        <!-- Reminder Form -->
                        <div class="row justify-content-center px-5">
                            <div class="col-sm-8 col-md-6 col-xl-4">
                                <!-- jQuery Validation functionality is initialized with .js-validation-reminder class in js/pages/op_auth_reminder.min.js which was auto compiled from _es6/pages/op_auth_reminder.js -->
                                <!-- For more examples you can check out https://github.com/jzaefferer/jquery-validation -->
                                <form class="js-validation-reminder" action="be_pages_auth_all.html" method="post">
                                   <div class="form-group m-100">
                                       
                                        <a class="btn btn-block btn-noborder btn-rounded btn-alt-secondary" href="index.aspx">
                                            <i class="si si-login text-muted mr-10"></i> Sign In
                                        </a>
                                    </div>
                                </form>
                            </div>
                        </div>
                        <!-- END Reminder Form -->
                    </div>
            
                    </div>
                <!-- END Page Content -->
                
            </main>
            <!-- END Main Container -->
        </div>
    </div>
    </form>

       <script src="assets/js/codebase.core.min.js"></script>

        <!--
            Codebase JS

            Custom functionality including Blocks/Layout API as well as other vital and optional helpers
            webpack is putting everything together at assets/_es6/main/app.js
        -->
    
        <script src="assets/js/codebase.app.min.js"></script>

        <!-- Page JS Plugins -->
        <script src="assets/js/plugins/jquery-validation/jquery.validate.min.js"></script>

        <!-- Page JS Code -->
        <script src="assets/js/pages/op_auth_reminder.min.js"></script>

</body>
</html>
