<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="empprofile.aspx.cs" Inherits="task_empdetails_empprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="ml-15 mr-15">

        <div class="block-header block-header-default ml-15 mr-15 mt-15">
            <h3 class="block-title">My Profile</h3>
        </div>

         <%=emp%>
    </div>
</asp:Content>

