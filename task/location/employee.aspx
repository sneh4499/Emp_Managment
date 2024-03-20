<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="employee.aspx.cs" Inherits="task_location_employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style>        
        #map {
            height:500px;            
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row ml-15 mr-15 mt-15">
        
        <div class="col-md-12">
     
        </div>
        <div class="col-md-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <div class="col-md-3">
                    <h3 class="block-title">All Employee live location</h3>
                        </div>
                    <div class="col-md-1"></div>
                   

                    <div class="col-md-4">
                             <label>Find Employee</label>
                    
                        <asp:DropDownList ID="DropDownList1" AppendDataBoundItems="true" runat="server" class="js-select2 form-control" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="email" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
                        <asp:ListItem Value="">Select here..</asp:ListItem>
                    </asp:DropDownList>
                       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [fname]+' '+[lname] as [name], [email] FROM [employee] order by [fname]+' '+[lname] ASC"></asp:SqlDataSource>
                     </div>

                     <div class="col-md-4">
                             <label>Search By Date</label>
                    
                        <asp:DropDownList ID="drddate" AppendDataBoundItems="true" runat="server" class="js-select2 form-control" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="date" DataValueField="date" OnSelectedIndexChanged="drddate_SelectedIndexChanged" >
                        <asp:ListItem Value="">Select here..</asp:ListItem>
                    </asp:DropDownList>
                       <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT FORMAT(CAST(date AS DATE), 'dd/MM/yyyy')   as date FROM [location] WHERE ([eid] LIKE '' + @eid + '')">
                           <SelectParameters>
                               <asp:ControlParameter ControlID="DropDownList1" Name="eid" PropertyName="SelectedValue" Type="String" />
                           </SelectParameters>
                             </asp:SqlDataSource>
                     </div>
                    <div class="block-options">
                    </div>
                </div>
                
                
                <div id="map"></div>
            </div>
        </div>
    </div>

    <%=map %>
</asp:Content>

