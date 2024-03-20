<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="emptask.aspx.cs" Inherits="task_emptask_emptask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row gutters-tiny mt-15 mr-30 ml-30">
       <%-- <div class="block-header block-header-default col-12 pl-20 pr-20 mb-20">
            <h3 class="block-title">Task Detail</h3>
        </div>--%>
        <!-- Pending -->
     <%--   <div class="col-md-6 col-xl-3">
            <a class="block block-rounded block-transparent bg-gd-sun" href="javascript:void(0)">
                <div class="block-content block-content-full block-sticky-options">
                    <div class="block-options">
                        <div class="block-options-item">
                            <i class="fa fa-spinner fa-spin text-white-op"></i>
                        </div>
                    </div>
                    <div class="py-20 text-center">
                        <div class="font-size-h2 font-w700 mb-0 text-white" data-toggle="countTo" data-to="12">0</div>
                        <div class="font-size-sm font-w600 text-uppercase text-white-op">Pending</div>
                    </div>
                </div>
            </a>
        </div>
        <!-- END Pending -->

        <!-- Canceled -->
        <div class="col-md-6 col-xl-3">
            <a class="block block-rounded block-transparent bg-gd-cherry" href="javascript:void(0)">
                <div class="block-content block-content-full block-sticky-options">
                    <div class="block-options">
                        <div class="block-options-item">
                            <i class="fa fa-times text-white-op"></i>
                        </div>
                    </div>
                    <div class="py-20 text-center">
                        <div class="font-size-h2 font-w700 mb-0 text-white" data-toggle="countTo" data-to="2">0</div>
                        <div class="font-size-sm font-w600 text-uppercase text-white-op">Canceled</div>
                    </div>
                </div>
            </a>
        </div>
        <!-- END Canceled -->

        <!-- Completed -->
        <div class="col-md-6 col-xl-3">
            <a class="block block-rounded block-transparent bg-gd-lake" href="javascript:void(0)">
                <div class="block-content block-content-full block-sticky-options">
                    <div class="block-options">
                        <div class="block-options-item">
                            <i class="fa fa-check text-white-op"></i>
                        </div>
                    </div>
                    <div class="py-20 text-center">
                        <div class="font-size-h2 font-w700 mb-0 text-white" data-toggle="countTo" data-to="21">0</div>
                        <div class="font-size-sm font-w600 text-uppercase text-white-op">Completed</div>
                    </div>
                </div>
            </a>
        </div>
        <!-- END Completed -->

        <!-- All -->
        <div class="col-md-6 col-xl-3">
            <a class="block block-rounded block-transparent bg-gd-dusk" href="javascript:void(0)">
                <div class="block-content block-content-full block-sticky-options">
                    <div class="block-options">
                        <div class="block-options-item">
                            <i class="fa fa-archive text-white-op"></i>
                        </div>
                    </div>
                    <div class="py-20 text-center">
                        <div class="font-size-h2 font-w700 mb-0 text-white" data-toggle="countTo" data-to="35">0</div>
                        <div class="font-size-sm font-w600 text-uppercase text-white-op">All</div>
                    </div>
                </div>
            </a>
        </div>--%>
        <!-- END All -->

        <div class="block col-12 p-0">
            <div class="block-header block-header-default">
                <h3 class="block-title">
                    <strong>Tasks</strong>
                </h3>
            </div>
            <div class="block-content block-content-full ">
                <div id="faq2" role="tablist" aria-multiselectable="true">
                    <div class="block block-bordered block-rounded mb-5">
                        <div class="block-header" role="tab" id="faq2_h1">
                            <a class="font-w600 text-body-color-dark w-100" data-toggle="collapse" href="#faq2_q1" aria-expanded="true" aria-controls="faq2_q1">Task Name
                              <%--  <p class="float-right m-0"><span class="badge badge-pill badge-success mr-10">Operational</span> date</p>--%>
                            </a>
                        </div>
                        <%--<div id="faq2_q1" class="collapse" role="tabpanel" aria-labelledby="faq2_h1" data-parent="#faq2">
                            <div class="block-content border-t pt-0">
                                <div class="row">
                                    <div class="col-sm-6 border-r">
                                        <div class="block block-rounded pt-15">
                                            <address class="detail_personal">
                                                <p><strong>Task Name: </strong>abc</p>
                                                <p><strong>Task Duration: </strong>abc</p>
                                                <p><strong>Task Locatoin: </strong>abc</p>
                                                <p><strong>Task Priority: </strong>abc</p>
                                            </address>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="block block-rounded pt-15">
                                            <address class="detail_personal">
                                                <p><strong>Description: </strong>abc</p>
                                                <p><strong>Members name: </strong>abc</p>
                                            </address>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>--%>

                        <div class="block-content">
             <div class="table-responsive">
                        <%=data%>
                 </div>
         
        </div>
                      
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>

