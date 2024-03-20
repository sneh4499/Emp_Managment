<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="task_work_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row ml-15 mr-15 mt-15 task_detail_page">
        <div class="col-12">
            <div class="block-header block-header-default">
                <h3 class="block-title">Job Detail</h3>

           
            </div>
        </div>
       <%=work%>
       
        </div>

</asp:Content>

