﻿<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="pending.aspx.cs" Inherits="task_activities_pending" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


      <div class="block mt-15 mr-30 ml-30">
        <div class="block-header block-header-default">
            <h3 class="block-title">Pending Jobs </h3>
            
        </div>
        <div class="block-content">s
             <div class="table-responsive">
                        <%=data%>
                 </div>
         
        </div>
          </div>
</asp:Content>

