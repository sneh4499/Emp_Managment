<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="task_employee_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Simple Wizards -->
    <!-- Simple Wizard 2 -->
    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
            <h3 class="block-title">Add Employee</h3>
        </div>
        <!-- Step Tabs -->
        <ul class="nav nav-tabs nav-tabs-alt nav-fill" role="tablist">
            <li class="nav-item">
                <a class="nav-link active" href="#wizard-simple2-step1" data-toggle="tab">1. Personal</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#wizard-simple2-step2" data-toggle="tab">2. Education</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#wizard-simple2-step3" data-toggle="tab">3. Bank</a>
            </li>
        </ul>
        <!-- END Step Tabs -->

        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content" style="min-height: 267px;">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                 

            

                <div class="row">
                    <div class="flex-container col-12 row employee_info_part">
                      
                          
                        
                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtfname" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-firstname">First Name</label>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtlname" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-lastname">Last Name</label>
                                        </div>
                                    </div>
                                </div>
                                 <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtfathername" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-lastname">Father Name</label>
                                        </div>
                                    </div>
                                </div>
                                  
                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtmothername" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-lastname">Mother Name</label>
                                        </div>
                                    </div>
                                </div>
                       


                          <div class="col-md-3 col-sm-6">
                                    <div class="form-group row">
                                        <label class="col-12" for="example-select">Department</label>
                                        <div class="col-md-12">
                                            

                                            <asp:DropDownList ID="dropdepartment" AppendDataBoundItems="true" runat="server" class="form-control" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="parentdept" DataValueField="parentdept">
                                                <asp:ListItem Value="">Select here..</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"  SelectCommand="SELECT DISTINCT [parentdept] FROM [department]"></asp:SqlDataSource>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group row">
                                        <label class="col-12" for="example-select">Sub-Department</label>
                                        <div class="col-md-12">
                                            <asp:DropDownList ID="dropsubdept" AppendDataBoundItems="true" runat="server" class="form-control" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="deptname" DataValueField="deptname">
                                                <asp:ListItem Value="">Select here..</asp:ListItem>
                                            </asp:DropDownList>

                                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [deptname] FROM [department] WHERE ([parentdept] = @parentdept)">
                                                <SelectParameters>
                                                    <asp:ControlParameter ControlID="dropdepartment" Name="parentdept" PropertyName="SelectedValue" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>

                                        </div>
                                    </div>
                                </div>
                                 





                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtdesignation" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-email">Designation</label>
                                        </div>
                                    </div>
                                </div>
                        
                         
                              

                         <div class="col-md-3 col-sm-6">
                         <label>Select Profile Picture</label>
                             <asp:FileUpload ID="fpimg" type="file" class="form-control" runat="server"></asp:FileUpload>

                         
                        </div>  
                               



                                <div class="col-md-3 col-sm-6">
                                    <div class="form-group">
                                        <div class="form-material floating">
                                            <asp:TextBox ID="txtpassword" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                            <label for="wizard-simple2-lastname">Password</label>
                                        </div>
                                    </div>
                                </div>

                                 <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtemail" class="form-control" required runat="server" name="wizard-simple2-firstname" ></asp:TextBox>
                                <label for="wizard-simple2-email">Email</label>
                            </div>
                        </div>
                    </div>
                         
                       
                        
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtnumber" class="form-control" runat="server"
                                    name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-email">Mobile No.</label>
                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="red" ErrorMessage="Enter 10 Digits Only" ValidationExpression="^[1-9][0-9]{9}$" Font-Bold="True" ControlToValidate="txtnumber"></asp:RegularExpressionValidator>--%>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtemergencyno" class="form-control" runat="server"
                                    name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-email">Emergency Contact No</label>
                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="red" ErrorMessage="Enter 10 Digits Only" ValidationExpression="^[1-9][0-9]{9}$" Font-Bold="True" ControlToValidate="txtemergencyno"></asp:RegularExpressionValidator>--%>
                            </div>
                        </div>
                    </div>
                   
                    </div>

                 

                      
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group row">
                             
                            <div class="form-material ">
                               <label class="col-12 ">Gender</label>
                                <br />
                            <asp:RadioButtonList CssClass="col-md-12" RepeatDirection="Horizontal"  ID="rdbtngender"  runat="server">
                                            <asp:ListItem class="col-md-6" Text="Male" Selected="True"></asp:ListItem>
                                            <asp:ListItem class="col-md-6" Text="Female"></asp:ListItem>
                                        </asp:RadioButtonList>
                               
                            </div>
                        </div>
                    </div>
 
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtweight" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Weight</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtheight" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Height</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtbloodgroup" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-email">Blood group</label>
                            </div>
                        </div>
                    </div>
                 




                  
                    <div class="col-md-6 col-sm-12">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtaddress" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-email">Home Address</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtcity" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-email">City</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtpincode" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-email">Pincode</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtstate" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-email">State</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtcountry" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-email">Country</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtremark" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Remark</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <label class="mb-10 d-block">Medical certificate</label>
                            <asp:FileUpload ID="fpmedicalcerti" runat="server" />
                        </div>
                    </div>
                  
                     <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <label class="mb-10 d-block">Adharcard</label>
                            <asp:FileUpload ID="fpadharcard" runat="server" />
                        </div>
                    </div>
                    
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <label class="mb-10 d-block">Pancard</label>
                            <asp:FileUpload ID="fppancard" runat="server" />
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <label class="mb-10 d-block">Joining Document</label>
                            <asp:FileUpload ID="fpjoindoc" runat="server" />
                        </div>
                    </div>
                   
                   


                      <div class="col-md-3 col-sm-6">
                                    <div class="form-group row">
                                        <label class="col-12" for="example-select">Select Role</label>
                                      
                                            <asp:DropDownList ID="drdrole" AppendDataBoundItems="true"  runat="server" class="form-control" >
                                                <asp:ListItem >Select here..</asp:ListItem>
                                                 <asp:ListItem Text="user" ></asp:ListItem>
                                                  <asp:ListItem Text="hr" ></asp:ListItem>
                                                 <asp:ListItem Text="management" ></asp:ListItem>
                                            </asp:DropDownList>

                                         

                                        </div>
                                   
                                </div>

                     <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtmaritalstatus" class="form-control up" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Marital Status</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtpfno" class="form-control up" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">PF Number</label>
                            </div>
                        </div>
                    </div>
                </div>

                             
                   
            </div>
            <!-- END Step 1 -->

            <!-- Step 2 -->
            <div class="tab-pane" id="wizard-simple2-step2" role="tabpanel">
                <div class="row">
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtqualification" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Qualification</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtpassingyear" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Month"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Passing Year</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtqualifipersentage" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Persentage</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-12">
                        <h5 class="mb-0 mt-10">Experience Details</h5>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtexpicompanyname" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Company Name</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtexpidesignation" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Designation</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtexpiduration" class="form-control" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Duration</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txttotalexperiance" class="form-control" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Total Experience</label>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <!-- END Step 2 -->

            <!-- Step 3 -->
            <div class="tab-pane" id="wizard-simple2-step3" role="tabpanel">
                <div class="row">
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtbankname" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Bank Name</label>
                            </div>
                        </div>
                    </div>
                     <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtbankbranchname" class="form-control up" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Bank Branch Name</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtbankacno" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Bank A/c No</label>
                            </div>
                        </div>
                    </div>
                    
               
                    

                </div>
                 <div class="row">
                    
                     <div class="col-md-4 col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtbankifscno" class="form-control up" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Bank IFSC No</label>
                            </div>
                        </div>
                    </div>


                     </div>
            </div>
            <!-- END Step 3 -->
        </div>
        <!-- END Steps Content -->

        <!-- Steps Navigation -->
        <div class="block-content block-content-sm block-content-full bg-body-light add_employee">
            <div class="row">
                <div class="col-md-6 col-6">
                    <button type="button" class="btn btn-alt-secondary" data-target="wizard-simple2-step2" data-wizard="prev"><i class="fa fa-angle-left mr-5"></i>Previous</button>
                </div>
                <div class="col-md-6 col-6 text-right">
                    <button type="button" class="btn btn-alt-secondary" data-wizard="next" onchange="function ()">Next <i class="fa fa-angle-right ml-5"></i></button>
                    <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="insert">Add</a>
                    <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="update">Update</a>

                    <%--<asp:Button runat="server" Text="Submit" class="js-swal-success btn btn-alt-primary" data-wizard="finish" ID="btnsave" OnClick="btnsave_Click1" />--%>
                    <%--<asp:Button runat="server" Text="Update" class="js-swal-success btn btn-alt-primary" data-wizard="finish" ID="btnupdate" OnClick="btnupdate_Click1"  />--%>
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->

        <!-- END Form -->
    </div>
    <!-- END Simple Wizard 2 -->
    <!-- END Simple Wizards -->


    <asp:Label ID="gender" AutoPostBack="false" runat="server" Visible="true"></asp:Label>
    <asp:Label ID="fileup" runat="server" Visible="true"></asp:Label>

  

    <%--Radio button--%>
    <%-- <script type="text/javascript">
        $(".custom-control-input").on('click', function () {
            var radioValue = $("input[name='gender']:checked").val();
            document.getElementById('<%=gender.ClientID%>').innerHTML = radioValue;
            document.getElementById("gender1").value = radioValue;
            window.location.href = "add.aspx?gender=" + radioValue + "&gender1=" + radioValue;
        });
    </script>--%>
    
<%--    <script>
          $(".custom-control-input").on('click', function () {
              var radioValue = $("input[name='gender']:checked").val();

              document.getElementById('<%=gender.ClientID%>').innerText = "?s=" + radioValue;
             // document.getElementById("gender1").value = radioValue;
              //alert(radioValue);
              
             // window.location.href = "?s=" + radioValue;

          });
       </script>--%>

    <%--File Upload--%>
    <%--<script type="text/javascript">
        $(".path").on('mouseleave', function () {
            document.getElementById('<%=fileup.ClientID%>').innerHTML = $(".file-ok span").text();
        });
    </script>--%>


    <div aria-labelledby="swal2-title" aria-describedby="swal2-content" class="m-auto swal2-popup swal2-modal swal2-show modal add_emp_modal" id="myModal" tabindex="-1" role="dialog" aria-live="assertive" aria-modal="true">
        <div class="swal2-header">
            <ul class="swal2-progress-steps" style="display: none;"></ul>
            <div class="swal2-icon swal2-error" style="display: none;"><span class="swal2-x-mark"><span class="swal2-x-mark-line-left"></span><span class="swal2-x-mark-line-right"></span></span></div>
            <div class="swal2-icon swal2-question" style="display: none;"></div>
            <div class="swal2-icon swal2-warning" style="display: none;"></div>
            <div class="swal2-icon swal2-info" style="display: none;"></div>
            <div class="swal2-icon swal2-success swal2-animate-success-icon" style="display: flex;">
                <div class="swal2-success-circular-line-left" style="background-color: rgb(255, 255, 255);"></div>
                <span class="swal2-success-line-tip"></span><span class="swal2-success-line-long"></span>
                <div class="swal2-success-ring"></div>
                <div class="swal2-success-fix" style="background-color: rgb(255, 255, 255);"></div>
                <div class="swal2-success-circular-line-right" style="background-color: rgb(255, 255, 255);"></div>
            </div>
            <img class="swal2-image" style="display: none;"><h2 class="swal2-title" id="swal2-title" style="display: flex;">Success</h2>
            <button type="button" class="swal2-close close" data-dismiss="modal" aria-label="Close this dialog">×</button>
        </div>
        <div class="swal2-content">
            <div id="swal2-content" style="display: block;">Everything updated perfectly!</div>
            <input class="swal2-input form-control" style="display: none;"><input type="file" class="swal2-file form-control" style="display: none;"><div class="swal2-range form-control" style="display: none;">
                <input type="range">
                <output></output>
            </div>
            <select class="swal2-select form-control" style="display: none;"></select><div class="swal2-radio form-control" style="display: none;"></div>
            <label for="swal2-checkbox" class="swal2-checkbox form-control" style="display: none;">
                <input type="checkbox"><span class="swal2-label"></span></label><textarea class="swal2-textarea form-control" style="display: none;"></textarea><div class="swal2-validation-message" id="swal2-validation-message" style="display: none;"></div>
        </div>
        <div class="swal2-actions" style="display: flex;">
            <%--<button type="button" class="swal2-confirm btn btn-alt-success m-5" aria-label="" style="display: inline-block;">OK</button>--%>
            <asp:Button runat="server" Text="Save" class=" btn btn-alt-primary" ID="btnsave" OnClick="btnsave_Click1" />
            <asp:Button runat="server" Text="Save" class=" btn btn-alt-primary" ID="btnupdate" OnClick="btnupdate_Click1" />
            <button type="button" class="swal2-cancel btn btn-alt-danger m-5" aria-label="" style="display: none;">Cancel</button>
        </div>
        <div class="swal2-footer" style="display: none;"></div>
    </div>



    <%--<script type="text/javascript">
        function UploadFile(fileUpload) {
            if (fileUpload.value != '') {
                document.getElementById("<%=btnfpimg.ClientID %>").click();

               }
           }
    </script>--%>
</asp:Content>
