<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="dailyactivity.aspx.cs" Inherits="task_reports_dailyactivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">Daily Activity Report</h3>
                    
                </div>
                <div class="block-content block-content-full">
                    <div class="row report_datepicker_row d-sm-block d-none">
                        <div class="col-md-8">
                            <div class="form-group row">
                                <label class="col-md-12 col-3 date_label form-material pt-0 text-md-left text-right" for="example-daterange1">Time Period</label>
                                <div class="col-md-8 col-6 date_picker">
                                    <div class="input-daterange input-group" data-date-format="mm/dd/yyyy" data-week-start="1" data-autoclose="true" data-today-highlight="true">
                                        <asp:TextBox ID="txtfromdate" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Date"></asp:TextBox>
                                        <div class="input-group-prepend input-group-append">
                                            <span class="input-group-text font-w600">to</span>
                                        </div>
                                        <asp:TextBox ID="txttodate" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3 col-3 sub_btn">
                                    <asp:Button ID="btnsearch" CssClass="btn btn-alt-primary" CausesValidation="false"  AutoPostBack = "True" Text="Search"  UseSubmitBehavior="False" runat="server"  OnClick="btnsearch_Click" />
                                   <%-- <button type="submit" class="btn btn-alt-primary">Submit</button>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- DataTables functionality is initialized with .js-dataTable-full class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
                    <div class="row">

                          <div class="col-md-3">
                                      <asp:Label ID="lblproj" runat="server" Text="Status" CssClass="form-group"></asp:Label>
                                   <asp:DropDownList ID="drdpendingsite" AppendDataBoundItems="True"  AutoPostBack="True" OnSelectedIndexChanged="drdpendingsite_SelectedIndexChanged"  runat="server" CssClass="js-select2 form-control" DataSourceID="SqlDataSource1" DataTextField="status" DataValueField="status">
                                         <asp:ListItem Text="Please select" Value="" />
                                   </asp:DropDownList>
                                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [status] FROM [schedule]"></asp:SqlDataSource>
                                </div>

                        <div class="col-md-3">
                                      <asp:Label ID="Label3" runat="server" Text="Uploded By" CssClass="form-group"></asp:Label>
                                   <asp:DropDownList ID="drduplodedby" AppendDataBoundItems="True"  AutoPostBack="True" OnSelectedIndexChanged="drduplodedby_SelectedIndexChanged"  runat="server" CssClass="js-select2 form-control" DataSourceID="SqlDataSource2" DataTextField="uploadby" DataValueField="uploadby">
                                         <asp:ListItem Text="Please select" Value="" />
                                   </asp:DropDownList>
                                      <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [uploadby] FROM [schedule]"></asp:SqlDataSource>
                                </div>

                        <div class="col-md-2">
                                    <%--  <asp:Label ID="Label1" runat="server" Text="Export Data" CssClass="form-group"></asp:Label>--%>
                                  <br />
                           
                                  <Button ID="btnexport" Text="Export" runat="server" CssClass="btn btn-success" onserverclick="btnexport_Click">

                                       <i class="fa fa-download mr-5"></i>
                                  </Button>
                                </div>
                    </div>

                    	<br />

                                <br />
                    
                         <div style="overflow-x: scroll">
                              <div class="block-content">
						<div class="table-responsive">
                              <%=data %>

                            
                          <asp:GridView ID="grdexp" runat="server"  CssClass="table table-bordered table-white" >
                             
                          </asp:GridView>
                                  
						
						</div>
</div>
					
                    </div>

                    
                </div>
            </div>
            <!-- END Dynamic Table Full -->
        </div>
    </div>

      <div class="col-12 bg-body-dark">

                       
                          
                          </div>
</asp:Content>

