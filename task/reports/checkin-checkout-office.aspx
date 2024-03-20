<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="checkin-checkout-office.aspx.cs" Inherits="task_reports_checkin_checkout_office" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
               <div class="block-header block-header-default">
                    <h3 class="block-title">Check in/Out From Office Report</h3>
                    
                </div>
                <div class="block-content block-content-full">
                    <div class="row report_datepicker_row d-sm-block d-none">
                       
                    </div>
                    <!-- DataTables functionality is initialized with .js-dataTable-full class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
                    <div class="row">

                         

                        <div class="col-md-3">
                                      <asp:Label ID="Label3" runat="server" Text="Select Employee" CssClass="form-group"></asp:Label>
                                   <asp:DropDownList ID="drdoffice" AppendDataBoundItems="True"  AutoPostBack="True" OnSelectedIndexChanged="drdoffice_SelectedIndexChanged"  runat="server" CssClass="js-select2 form-control" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="email">
                                         <asp:ListItem Text="Please select" Value="" />
                                   </asp:DropDownList>
                                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT fname+' '+lname AS [Name],email FROM [employee] order by [fname]+' '+[lname] ASC"></asp:SqlDataSource>
                                </div>

                        
                                  <div class="col-md-2">
                                    <%--  <asp:Label ID="Label1" runat="server" Text="Export Data" CssClass="form-group"></asp:Label>--%>
                                  <br />
                           
                                  <Button ID="btnexport" Text="Export" runat="server" CssClass="btn btn-success" onserverclick="btnexport_ServerClick">

                                       <i class="fa fa-download mr-5"></i>
                                  </Button>
                                </div>
                    </div>

                    	<br />

                                <br />
                    
                         <div style="overflow-x: scroll">
                           
						<div class="table-responsive" id="dev-table">
                              <%=data %>

                               
                          <asp:GridView ID="grdexp" runat="server"  CssClass="table table-bordered table-white" >
                             
                          </asp:GridView>
                                         <%-- <asp:GridView ID="grdreport" runat="server"  CssClass="table table-bordered table-white"      BorderColor="White" >
                                              
                   

                                             

               </asp:GridView>--%>

                     

						
						</div>

					
                    </div>
                </div>
            </div>
            <!-- END Dynamic Table Full -->
  
                  </div>
     
          </div>
</asp:Content>

