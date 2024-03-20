<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="forgetpassword.aspx.cs" Inherits="forgetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <meta charset="utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no"/>

        <title>EMP Trackbean</title>

        <meta name="description" content="Codebase - Bootstrap 4 Admin Template &amp; UI Framework created by pixelcave and published on Themeforest"/>
        <meta name="author" content="pixelcave"/>
        <meta name="robots" content="noindex, nofollow"/>

        <!-- Open Graph Meta -->
        <meta property="og:title" content="Codebase - Bootstrap 4 Admin Template &amp; UI Framework"/>
        <meta property="og:site_name" content="Codebase"/>
        <meta property="og:description" content="Codebase - Bootstrap 4 Admin Template &amp; UI Framework created by pixelcave and published on Themeforest">
        <meta property="og:type" content="website"/>
        <meta property="og:url" content=""/>
        <meta property="og:image" content=""/>

        <!-- Icons -->
        <!-- The following icons can be replaced with your own, they are used by desktop and mobile browsers -->
        <link rel="shortcut icon" href="assets/media/favicons/favicon.png"/>
        <link rel="icon" type="image/png" sizes="192x192" href="assets/media/favicons/favicon-192x192.png"/>
        <link rel="apple-touch-icon" sizes="180x180" href="assets/media/favicons/apple-touch-icon-180x180.png"/>
        <!-- END Icons -->

        <!-- Stylesheets -->

        <!-- Fonts and Codebase framework -->
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Muli:300,400,400i,600,700"/>
        <link rel="stylesheet"  href="assets/css/codebase.min.css"/>
    
        <!-- You can include a specific file from css/themes/ folder to alter the default color theme of the template. eg: -->
        <!-- END Stylesheets -->
</head>
<body>
    <form id="form1" runat="server">
   <div id="page-container" class="main-content-boxed">

            <!-- Main Container -->
            <main id="main-container">

                <!-- Page Content -->
                <div class="bg-body-dark bg-pattern" style="background-image: url('assets/media/various/bg-pattern-inverse.png');">
                    <div class="row mx-0 justify-content-center">
                        <div class="hero-static col-lg-6 col-xl-4">
                            <div class="content content-full overflow-hidden">
                                <!-- Header -->
                                <div class="py-30 text-center">
                                  <div>
                                        <img src="" style="height:50%;width:100%" class="img-fluid"/>
                 </div>    <h1 class="h4 font-w700 mt-30 mb-10">Forget Password</h1>
                                      </div>
                                <!-- END Header -->

                                <!-- Reminder Form -->
                                <!-- jQuery Validation functionality is initialized with .js-validation-reminder class in js/pages/op_auth_reminder.min.js which was auto compiled from _es6/pages/op_auth_reminder.js -->
                                <!-- For more examples you can check out https://github.com/jzaefferer/jquery-validation -->
                                <form class="js-validation-reminder" action="be_pages_auth_all.html" method="post">
                                    <div class="block block-themed block-rounded block-shadow">
                                        <div class="block-header bg-gd-primary">
                                            <h3 class="block-title">Password Reminder</h3>
                                            <div class="block-options">
                                                    <i class="fa fa-key"></i>
                                               </div>
                                        </div>
                                        <div class="block-content">
                                            <div class="form-group row">
                                                <div class="col-12">
                                                     <div class="form-material floating">
                                                <asp:textbox id="txtemail"  class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="Email" ></asp:textbox>
                                 <label for="wizard-simple2-firstname">Enter Your Email</label>
                              </div>
                                                </div>
                                            </div>
                                            <div class="form-group text-center">
                                               <%-- <button type="submit" class="btn btn-alt-primary" onclick="dynNotice()">
                                                    <i class="fa fa-asterisk mr-10"></i> Password Reminder
                                                </button>--%>
                                                <asp:Button ID="Button1" runat="server" class="btn btn-alt-primary" Text="Get Your Password" OnClick="Button1_Click"  OnClientClick="dynNotice()"></asp:Button>
                                            </div>
                                        </div>
                                                                           </div>
                                </form>
                                <!-- END Reminder Form -->
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END Page Content -->

            </main>
            <!-- END Main Container -->
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


    <script>
        function dynNotice() {
            var percent = 0;
            var notice = PNotify.info({
                text: 'Please Wait',
                icon: 'fas fa-spinner fa-pulse',
                hide: false,
                shadow: false,
                width: '200px',
                modules: {
                    Buttons: {
                        closer: false,
                        sticker: false
                    }
                }
            });

            setTimeout(function () {
                notice.update({
                    title: false
                });
                var interval = setInterval(function () {
                    percent += 2;
                    var options = {
                        text: percent + '% complete.'
                    };
                    if (percent === 80) {
                        options.title = 'Almost There';
                    }
                    if (percent >= 100) {
                        window.clearInterval(interval);
                        options.title = 'Done!';
                        options.type = 'success';
                        options.hide = true;
                        options.icon = 'fas fa-check';
                        options.shadow = true;
                        options.width = PNotify.defaults.width;
                        options.modules = {
                            Buttons: {
                                closer: true,
                                sticker: true
                            }
                        };
                    }
                    notice.update(options);
                }, 120);
            }, 2000);

           // alert('test')
        }
    </script>
</body>
</html>
