<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="task_work_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    
    <div class="block mt-15 mr-30 ml-30">
        <div class="block-header block-header-default">
            <h3 class="block-title">Job View</h3>
              <div class="float-left">
                           <Button ID="btnexport" runat="server" CausesValidation="false" class="btn btn-success" onserverclick="btnexport_ServerClick">
                        <i class="fa fa-download mr-5"></i>
               
                         </Button>
                    </div>
        </div>
        <div class="block-content">
             <div class="table-responsive">
                        <%=work%>
                 </div>
         
        </div>

           <asp:GridView CssClass="table-responsive" Visible="false"  ID="grdexp" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" >
               <Columns>
                   <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                   <asp:BoundField DataField="datetime" HeaderText="date" SortExpression="datetime" />
                   <asp:BoundField DataField="workname" HeaderText="Work Name" SortExpression="workname" />
                   <asp:BoundField DataField="sitename" HeaderText="Site Name" SortExpression="sitename" />
                   <asp:BoundField DataField="worklocation" HeaderText="Work Location" SortExpression="worklocation" />
                   <asp:BoundField DataField="timefrom" HeaderText="Time From" SortExpression="timefrom" />
                   <asp:BoundField DataField="timeto" HeaderText="Time To" SortExpression="timeto" />
                   <asp:BoundField DataField="workpriority" HeaderText="Work Priority" SortExpression="workpriority" />
                   <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                  
                   <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                   <asp:BoundField DataField="jobcode" HeaderText="Jobcode" SortExpression="jobcode" />
                   <asp:BoundField DataField="reference" HeaderText="Reference" SortExpression="reference" />
                   <asp:BoundField DataField="pono" HeaderText="Pono" SortExpression="pono" />
                  
               </Columns>
               
            </asp:GridView>
           
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [id], [datetime], [workname], [sitename], [worklocation], [timefrom], [timeto], [workpriority], [description], [files], [Status], [jobcode], [reference], [pono] FROM [work]"></asp:SqlDataSource>
           
    </div>

</asp:Content>

