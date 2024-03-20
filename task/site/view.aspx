<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="task_company_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">All Customer</h3>
                    <div class="float-left">
                           <Button ID="btnexport" runat="server" CausesValidation="false" class="btn btn-success" onserverclick="btnexport_Click">
                        <i class="fa fa-download mr-5"></i>
               
                         </Button>
                    </div>
                </div>
                <div class="block-content block-content-full">
                    <div class="table-responsive">
                        <%=site%>
                 </div>
                    <!-- DataTables functionality is initialized with .js-dataTable-full class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
                  
                </div>
            </div>
            <!-- END Dynamic Table Full -->

            <asp:GridView CssClass="table-responsive" Visible="false" ID="grdexp" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="datetime" HeaderText="date" SortExpression="datetime" />
                    <asp:BoundField DataField="sitename" HeaderText="Site Name" SortExpression="sitename" />
                    <asp:BoundField DataField="location" HeaderText="Location" SortExpression="location" />
                    <asp:BoundField DataField="contactperson" HeaderText="Contact Person" SortExpression="contactperson" />
                    <asp:BoundField DataField="mobileno" HeaderText="Mobileno" SortExpression="mobileno" />
                    <asp:BoundField DataField="longitude" HeaderText="Longitude" SortExpression="longitude" />
                    <asp:BoundField DataField="latitude" HeaderText="Latitude" SortExpression="latitude" />
                    <asp:BoundField DataField="Landline" HeaderText="Landline" SortExpression="Landline" />
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [site]"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

