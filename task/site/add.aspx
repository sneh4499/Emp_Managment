<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="task_company_add" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">Add Customer</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content" style="min-height: 267px;">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                
                <div class="row">
                    <div class="col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtsitename" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Name</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtlocation" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-lastname">Location</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-6 ">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtcontactperson" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Contact Person Name</label>
                            </div>
                        </div>
                    </div>
 <div class="col-sm-6 ">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtemail" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Email</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtmobileno" class="form-control cap" runat="server" required="" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Mobile No.</label>
                            </div>
                        </div>
                    </div>
                     <div class="col-sm-6 ">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtlandline" class="form-control cap" TextMode="Number" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Landline No</label>
                            </div>
                        </div>
                    </div>


                     <div class="col-sm-6 ">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtlatitude" class="form-control cap" step="any" Visible="false" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname" style="display:none">Latitude</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-6">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtlongitude" class="form-control cap" Visible="false" step="any" runat="server" name="wizard-simple2-firstname" TextMode="Number"></asp:TextBox>
                                <label for="wizard-simple2-firstname" style="display:none">Longitude</label>
                            </div>
                        </div>
                    </div>

                    
                </div>
            </div>
            <!-- END Step 1 -->

        </div>
        <!-- END Steps Content -->

        <!-- Steps Navigation -->
        <div class="block-content block-content-sm block-content-full bg-body-light">
            <div class="row">

                <div class="col-md-12 text-center">

                    <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="insert">Add</a>
                    <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="update">Update</a>

                   
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->

        <!-- END Form -->
    </div>



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
            <button type="button" class="swal2-close close"  data-dismiss="modal" aria-label="Close this dialog">×</button>
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
             <asp:button runat="server" text="Submit" class="btn btn-alt-primary" data-wizard="finish" ID="btnsave" OnClick="btnsave_Click"/>
                    <asp:button runat="server" text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" OnClick="btnupdate_Click"/>
                    <button type="button" class="swal2-cancel btn btn-alt-danger m-5" aria-label="" style="display: none;">Cancel</button>
        </div>
        <div class="swal2-footer" style="display: none;"></div>
    </div>

    
</asp:Content>

