<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="extremelysearch.aspx.cs" Inherits="task_reports_extremelysearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">Power Search</h3>
                   
                </div>
                <div class="block-content block-content-full">
                    <div class="row report_datepicker_row d-sm-block d-none">
                        <div class="col-md-12">
                              <div class="row">


                                                <div class="col-md-3">
												
                                                    <asp:TextBox ID="TextBox1"  CssClass="form-control input-xs border-teal" runat="server" class="form-control"></asp:TextBox>
                                                  
												</div>
                        
                         <br />
                                    <br />
                                                 <div class="col-md-3">
													
                                                
												
				                           <asp:Button ID="btnsearch" CssClass="btn btn-alt-primary" CausesValidation="false"  AutoPostBack = "True" Text="Search"  UseSubmitBehavior="False" runat="server" OnClick="btnsearch_Click"  />
												</div>
                     </div>
                       <div style="overflow-x:scroll" >

                   
                         <%=data %>

                          
                      <script> jQuery(document).ready(function ($) {
     $(".clickable-row").click(function () {
         window.location = $(this).data("href");
     });
 });
                          //window.onload = function () {
                          //    var userImage = document.getElementsByClassName('clickable-row');
                          //    userImage.onclick = function () {
                          //        window.location.href = userImage.getAttribute('href');
                          //    };
                          //};
                          </script>
            <!-- New widget -->
            
          
            <!-- End .powerwidget --> 
          </div>
                        </div>
                      
                        
                    </div>
                    <!-- DataTables functionality is initialized with .js-dataTable-full class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
                    

               
                </div>
            </div>
            <!-- END Dynamic Table Full -->
        </div>
    </div>
</asp:Content>

