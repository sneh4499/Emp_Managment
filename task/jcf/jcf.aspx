<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="jcf.aspx.cs" Inherits="task_jcf_jcf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">J C F</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content" style="min-height: 267px;">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                  <div class="row">
                       <div class="col-md-3">
                        <div class="form-group row">
                            <label class="col-12 " for="example-select">Job Code</label>
                            <div class="col-md-12 form-material floating">
                                <asp:TextBox id="txtjobcode" AppendDataBoundItems="True" runat="server" class="form-control" >
                                    
                                </asp:TextBox>
                                
                            </div>
                        </div>
                    </div>
                      <div class="col-md-3 ">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtclientname" ReadOnly="true" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Client Name</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtaddress" ReadOnly="true" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Address</label>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtjobdetails" ReadOnly="true"  class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Job Details</label>
                            </div>
                        </div>
                    </div>
                      <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtstartdate" ReadOnly="true" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Start Date</label>
                            </div>
                        </div>
                    </div>
                      <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtfinishdate" class="form-control cap" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Finish Date</label>
                            </div>
                        </div>
                    </div>
                      

                 <div class="col-md-3">
                        <div class="form-group">
                            <label for="wizard-simple2-lastname">Remarks For Job</label>
                                <asp:DropDownList ID="drdremarksforjob"  AppendDataBoundItems="true" OnSelectedIndexChanged="drdremarksforjob_SelectedIndexChanged" AutoPostBack="true" class="form-control" runat="server" >
                                    <asp:ListItem Text="Select here.."></asp:ListItem>
                                      <asp:ListItem Text="Completed"></asp:ListItem>
                                      <asp:ListItem Text="Not Completed"></asp:ListItem>
                                      <asp:ListItem Text="Second Visit Required"></asp:ListItem>
                                      <asp:ListItem Text="New Job requirement"></asp:ListItem>
                                      <asp:ListItem Text="Material/Tools Required"></asp:ListItem>
                                      <asp:ListItem Text="Other"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                    </div>

                      <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtreason" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Reason</label>
                            </div>
                        </div>
                    </div>

                      <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtcolleaguesname" ReadOnly="true" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Colleague Name</label>
                            </div>
                        </div>
                    </div>
                       <div class="col-md-3">
                        <div class="form-group">
                            <div class="form-material floating">
                                <asp:TextBox ID="txtspecialremarks" class="form-control cap" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Special Remarks</label>
                            </div>
                        </div>
                    </div>


               </div>


                 
            </div>

             <div class="row"><div class="col-md-2">Srno</div><div class="col-md-4">JOB COMPLITION DETAILS</div><div class="col-md-3">To Whom</div><div class="col-md-3">YES/NO/NA</div></div>
            <div class="content">

                <div class="block">

<div class="table-responsive">
               
                 <div style="overflow-x:scroll">
                    
                      <%=data %>
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
                    <asp:Button runat="server" ID="btnsave" Text="Add" CssClass="btn btn-alt-primary" OnClick="btnsave_Click"  />
                    <%-- <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="insert">Add</a>--%>
                    <%--<a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="update">Update</a>--%>

                    
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->

        <!-- END Form -->
    </div>
    
</asp:Content>

