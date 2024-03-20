<%@ Page Title="" Language="C#" MasterPageFile="~/department/management/management.master" AutoEventWireup="true" CodeFile="pending.aspx.cs" Inherits="task_schedule_pending" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
            <div class="block mt-15 mr-30 ml-30">
        <div class="block-header block-header-default">
            <h3 class="block-title">Schedule View</h3>
             <div class="float-left">
                           <Button ID="btnexport" runat="server" CausesValidation="false" class="btn btn-success" onserverclick="btnexport_ServerClick">
                        <i class="fa fa-download mr-5"></i>
               
                         </Button>
                    </div>
        </div>
        <div class="block-content">
             <div class="table-responsive">
                        <%=schedule%>
                 </div>
         
        </div>

                <asp:GridView ID="grdexp" runat="server" Visible="false" CssClass="table-responsive" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="datetime" HeaderText="datetime" SortExpression="datetime" />
                        <asp:BoundField DataField="sitename" HeaderText="sitename" SortExpression="sitename" />
                        <asp:BoundField DataField="workname" HeaderText="workname" SortExpression="workname" />
                        <asp:BoundField DataField="todate" HeaderText="todate" SortExpression="todate" />
                        <asp:BoundField DataField="fromdate" HeaderText="fromdate" SortExpression="fromdate" />
                        <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                        <asp:BoundField DataField="assignedemps" HeaderText="assignedemps" SortExpression="assignedemps" />
                        <asp:BoundField DataField="teamleader" HeaderText="teamleader" SortExpression="teamleader" />
                        <asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" />
                        <asp:BoundField DataField="uploadby" HeaderText="uploadby" SortExpression="uploadby" />
                        <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                        <asp:BoundField DataField="Jobcode" HeaderText="Jobcode" SortExpression="Jobcode" />
                        <asp:BoundField DataField="Visitfor" HeaderText="Visitfor" SortExpression="Visitfor" />
                        <asp:BoundField DataField="Travelby" HeaderText="Travelby" SortExpression="Travelby" />
                        <asp:BoundField DataField="Travelto" HeaderText="Travelto" SortExpression="Travelto" />
                        <asp:BoundField DataField="Jobdetail" HeaderText="Jobdetail" SortExpression="Jobdetail" />
                        <asp:BoundField DataField="Testcertificate" HeaderText="Testcertificate" SortExpression="Testcertificate" />
                        <asp:BoundField DataField="Testingequipment" HeaderText="Testingequipment" SortExpression="Testingequipment" />
                        <asp:BoundField DataField="reachingtime" HeaderText="reachingtime" SortExpression="reachingtime" />
                        <asp:BoundField DataField="Reportingtime" HeaderText="Reportingtime" SortExpression="Reportingtime" />
                        <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [schedule] where status like 'Pending'"></asp:SqlDataSource>
    </div>
       
</asp:Content>

