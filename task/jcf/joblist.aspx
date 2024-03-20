<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="joblist.aspx.cs" Inherits="task_jcf_joblist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">Job Completion List</h3>
        </div>

                     <div class="block-content block-content-full tab-content" >
             <!-- Step 1 -->
         
                        <div class="block-content block block-link-shadow">
                             
                 <div class="table-responsive">
                        <%=data%>
                 </div>
                     
     

                            </div>
       
   
                   
                     </div>
                     </div>

</asp:Content>

