<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="task_employee_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="ml-15 mr-15">

        <div class="block-header block-header-default ml-15 mr-15 mt-15">
            <h3 class="block-title">Employee Detail</h3>
        </div>
                    <div class="table-responsive">
        <%=emp%>

</div>
       
    </div>

 
</asp:Content>

