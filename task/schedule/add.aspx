﻿<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="task_schedule_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
   
    <link href="../../typename-plugin/chosen.css" rel="stylesheet" />
  
    <link href="../../typename-plugin/docsupport/prism.css" rel="stylesheet" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
            <h3 class="block-title">Add Schedule</h3>
        </div>
        <div class="block-content">
            <div class="row">
                 <div class="col-md-3 col-sm-12 col-xs-12">
          
                        <div class="form-group ">
                    <label for="example-select2-multiple">Select Job Code</label>
                     <asp:DropDownList ID="drdjobcode"  OnSelectedIndexChanged="drdjobcode_SelectedIndexChanged" AppendDataBoundItems="True"  runat="server" class="js-select2 form-control"   AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="jobcode" DataValueField="jobcode" >
                            <asp:ListItem  Value="">Select here..</asp:ListItem>
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [jobcode] FROM [work] where Status NOT LIKE 'Completed' ORDER BY [jobcode] desc"></asp:SqlDataSource>
                        </div>
                </div>
                <div class="col-md-3 col-sm-12 col-xs-12">
                    <div class="form-group ">
                        <label for="example-select">Customername</label>
                        <%--OnSelectedIndexChanged="dropsitename_SelectedIndexChanged"--%>
                        <asp:DropDownList ID="dropsitename" ReadOnly="true"  AppendDataBoundItems="true"  runat="server" class="form-control"    >
                            <asp:ListItem Value="">Select here..</asp:ListItem>
                        </asp:DropDownList>
                        
                    </div>
                </div>

                   
                
               
                <div class="col-md-3 col-sm-12 col-xs-12">
                    <div class="form-group">
                        <div class="form-material floating">
                             <label for="wizard-simple2-lastname">Job Name</label>
                            <asp:DropDownList ID="drdworkname" ReadOnly="true" AppendDataBoundItems="true"  class="form-control" runat="server" name="wizard-simple2-firstname">
                                <asp:ListItem Text="Please Select"></asp:ListItem>
                            </asp:DropDownList>
                           
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="form-group">
                        <div class="form-material floating">
                            <asp:TextBox ID="txtlocation" ReadOnly="false" class="form-control" TextMode="MultiLine" runat="server" name="wizard-simple2-firstname" AutoPostBack="True"></asp:TextBox>
                            <label for="wizard-simple2-lastname">Location</label>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [location] FROM [site] WHERE ([sitename] = @sitename)">
                                                <SelectParameters>
                                                    <asp:ControlParameter ControlID="dropsitename" Name="location" PropertyName="SelectedValue" Type="String" />
                                                </SelectParameters>
                                            </asp:SqlDataSource>
                            </div>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="form-group row">
                     
                        <div class="col-lg-12">
                              <label  for="example-daterange1">Time Period</label>
                             <p class="badge badge-primary">Last Fromdate is : <%=fromdate %> || Todate is :<%=todate %></p>
                            <div class="input-daterange input-group" >
                                 
                                <asp:TextBox ID="txtfromdate" required class="form-control" runat="server"  type="date"></asp:TextBox>
                                <div class="input-group-prepend input-group-append">
                                    <span class="input-group-text font-w600">to</span>
                                </div>
                                <asp:TextBox ID="txttodate" required  class="form-control" runat="server"  type="date"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
               
                
                <div class="col-md-6 col-sm-6">
                    <label  for="example-select2-multiple">Select Employee</label>
                     <p class="badge badge-primary">Last Team is : <%=emp1 %></p>
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="emplist" id="emplist" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=emp %>
                            </select>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <label for="example2-select2" >Select Truck Number</label>
                     <p class="badge badge-primary">Last Truck Number is : <%=teamleader %></p>
                    
                        <asp:DropDownList ID="drdtruck" runat="server" AppendDataBoundItems="true" CssClass="js-select2 form-control" required="required" DataSourceID="SqlDataSource1" DataTextField="trucknumber" DataValueField="trucknumber">
                            <asp:ListItem>Please Select</asp:ListItem>
                        </asp:DropDownList>
                        
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [trucknumber] FROM [truck]"></asp:SqlDataSource>
                        
                        <%--<select class="js-select2 form-control" required="required" name="emptl" style="width: 100%;" data-placeholder="Choose one..">
                            <option></option>
                            <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                             <%=emp %>
                            </select>--%>
                        
                    
                </div>
                  
                  <div class="col-md-3">
                    <div class="form-group">
                        <div class="form-material floating">
                            <asp:TextBox ID="txtjobdetail" class="form-control"  runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                            <label for="wizard-simple2-lastname">Additional Info</label>
                        </div>
                    </div>
                </div>
                 
                 

                
                 
                <div class="col-md-3">
                    <div class="form-group">
                        <div class="form-material floating">
                            <asp:TextBox ID="txtremark" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                            <label for="wizard-simple2-lastname">Remark</label>
                        </div>
                    </div>
                </div>

                

                 
                
            </div>
        </div>

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
            <asp:Button runat="server" Text="Submit" class="btn btn-alt-primary" data-wizard="finish" ID="btnsave" OnClick="btnsave_Click" />
            <asp:Button runat="server" Text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" OnClick="btnupdate_Click" />
            <button type="button" class="swal2-cancel btn btn-alt-danger m-5" aria-label="" style="display: none;">Cancel</button>
        </div>
        <div class="swal2-footer" style="display: none;"></div>
    </div>

   
    <script src="../../typename-plugin/init.js"></script>

    <script src="../../typename-plugin/docsupport/prism.js"></script>
</asp:Content>
