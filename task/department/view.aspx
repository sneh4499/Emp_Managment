<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="task_department_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">All Department</h3>
                </div>
                 <div class="table-responsive">
               
                        <%=dept%>
                  </div>

            </div>

            <!-- END Dynamic Table Full -->
        </div>
    </div>
</asp:Content>

