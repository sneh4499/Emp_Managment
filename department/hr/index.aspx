<%@ Page Title="" Language="C#" MasterPageFile="~/department/hr/hr.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="department_hr_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <main id="main-container">

                <!-- Page Content -->
                <div class="content">
                    <div class="row invisible" data-toggle="appear">
                        <!-- Row #4 -->
                        <div class="col-md-6">
                            <a class="block block-link-shadow overflow-hidden" href="javascript:void(0)">
                                <div class="block-content block-content-full bg-primary">
                                    <i class="si si-user fa-2x text-body-bg-dark"></i>
                                    <div class="row py-20">
                                        <div class="col-6 text-right border-r">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInLeft">
                                                <div class="font-size-h3 font-w600" style="color:white"><%=totalemp %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted" ><span style="color:white">Total  Employee</span></div>
                                            </div>
                                        </div>
                                       <%-- <div class="col-6">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInRight">
                                                <div class="font-size-h3 font-w600"><%=pendingtask %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Pending Task</div>
                                            </div>
                                        </div>--%>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <%--<div class="col-md-6">
                            <a class="block block-link-shadow overflow-hidden" href="javascript:void(0)">
                                <div class="block-content block-content-full">
                                    <div class="text-right">
                                        <i class="si si-users fa-2x text-body-bg-dark"></i>
                                    </div>
                                    <div class="row py-20">
                                        <div class="col-6 text-right border-r">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInLeft">
                                                <div class="font-size-h3 font-w600 text-info"><%=hrs%></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Worked Jobs</div>
                                            </div>
                                        </div>
                                        <div class="col-6">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInRight">
                                                <div class="font-size-h3 font-w600 text-success"><%=days%></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Attended Days</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>--%>
                        <!-- END Row #4 -->
                    </div>
                    
                    <div class="row invisible" data-toggle="appear">
                        <!-- Row #2 -->
                        
                        <div class="col-md-12">
                            <div class="block">
                                <div class="block-header">
                                    <h3 class="block-title">
                                        Employee <small>List</small>
                                    </h3>
                                    <div class="block-options">
                                        <button type="button" class="btn-block-option" data-toggle="block-option" data-action="state_toggle" data-action-mode="demo">
                                            <i class="si si-refresh"></i>
                                        </button>
                                        <%--<button type="button" class="btn-block-option">
                                            <i class="si si-wrench"></i>
                                        </button>--%>
                                    </div>
                                </div>

                                 <div class="table-responsive">
                                <%=data %>
                                     </div>
                               
                            </div>
                        </div>
                        <!-- END Row #2 -->
                    </div>
                    
                    
                    
                </div>
                <!-- END Page Content -->

            </main>
</asp:Content>

