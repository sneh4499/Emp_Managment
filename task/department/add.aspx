<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="task_department_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolder1" runat="Server">
     <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">Add Department</h3>
        </div>
         <!-- Form -->

         <!-- Steps Content -->
         <div class="block-content block-content-full tab-content" style="min-height: 267px;">
             <!-- Step 1 -->
             <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">

                 <div class="row">
                     <div class="col-md-4">
                         <div class="form-group">
                             <div class="form-material floating">
                                 <asp:textbox id="txtdepartmentname"  class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:textbox>
                                 <label for="wizard-simple2-firstname">Department Name</label>
                             </div>
                         </div>
                     </div>
                     
                     <div class="col-md-4 ">
                         <div class="form-group p-0 mt-20">
                             <div class="form-material p-0 ">
                                 <label for="example-select" class="department_checkbox position-relative">
                                     Add Parent Department
                                <input type="checkbox" class="form-control" onclick="parentdept()" id="check" runat="server">
                                     <span class="checkmark"></span>
                                 </label>
                             </div>
                         </div>
                     </div>

                     <div class="col-md-4" id="parentdept">
                         <div class="form-group">
                             <div class="perent_department_sec">
                                 <label for="example-select" class="position-relative">Parent Department</label>
                                 <asp:DropDownList ID="dropparentdept" runat="server" class="form-control">
                                     <asp:ListItem Value="">Select here..</asp:ListItem>
                                 </asp:DropDownList>
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

    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">All Department</h3>
        </div>

                     <div class="block-content block-content-full tab-content" >
             <!-- Step 1 -->
             <div class="tab-pane active" id="wizard-simple2-step" role="tabpanel">

                 <div class="row">

                     <asp:GridView ID="grd" runat="server"  CssClass="table table-striped table-vcenter" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                         <Columns>
                             <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                             <asp:BoundField DataField="deptname" HeaderText="Department Name" SortExpression="deptname" />
                             <asp:BoundField DataField="parentdept" HeaderText="Parent Department" SortExpression="parentdept" />
                             <asp:CommandField ButtonType="Button" ShowEditButton="True" ControlStyle-CssClass="btn btn-success" />
                         </Columns>
                     </asp:GridView>
                    
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [id],[deptname], [parentdept] FROM [department]" UpdateCommand="update department set deptname=@deptname,parentdept=@parentdept where id=@id"></asp:SqlDataSource>
                    
                    
                      </div>
                 </div>
                     </div>
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
           <asp:button runat="server" text="Submit" class=" btn btn-alt-primary" data-wizard="finish" ID="btnsave" OnClick="btnsave_Click"/>
           <asp:button runat="server" text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" OnClick="btnupdate_Click"/>
            <button type="button" class="swal2-cancel btn btn-alt-danger m-5" aria-label="" style="display: none;">Cancel</button>
        </div>
        <div class="swal2-footer" style="display: none;"></div>
    </div>



 

<script>
           {
               document.getElementById("parentdept").style.display = "none";
           }

           function parentdept() {
               var x = document.getElementById("parentdept");
               if (x.style.display === "none") {
                   x.style.display = "block";
               } else {
                   x.style.display = "none";
               }
           }
</script>


</asp:content>

