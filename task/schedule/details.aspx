<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="task_schedule_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="row gutters-tiny">
                        <!-- Row #6 -->
                        <div class="col-md-6 col-xl-3">
                            <a class="block block-transparent" href="javascript:void(0)">
                                <div class="block-content block-content-full bg-warning text-center">
                                    <div class="item item-2x item-circle bg-black-op-10 mx-auto mb-20">
                                        <i class="fa fa-users text-white-op"></i>
                                    </div>
                                    <div class="font-size-h3 font-w600 text-white"><%=totalteam %></div>
                                    <div class="font-size-sm font-w600 text-uppercase text-white-op">Total Team</div>
                                </div>
                            </a>
                        </div>
                        
                        <div class="col-md-6 col-xl-3">
                            <a class="block block-transparent" href="javascript:void(0)">
                                <div class="block-content block-content-full bg-primary text-center">
                                    <div class="item item-2x item-circle bg-black-op-10 mx-auto mb-20">
                                        <i class="si si-wrench text-white-op"></i>
                                    </div>
                                    <div class="font-size-h3 font-w600 text-white"><%=totalcheckin %></div>
                                    <div class="font-size-sm font-w600 text-uppercase text-white-op">Check In</div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-6 col-xl-3">
                            <a class="block block-transparent" href="javascript:void(0)">
                                <div class="block-content block-content-full bg-success text-center">
                                    <div class="item item-2x item-circle bg-black-op-10 mx-auto mb-20">
                                        <i class="si si-check text-white-op"></i>
                                    </div>
                                    <div class="font-size-h3 font-w600 text-white"><%=totalchekout %></div>
                                    <div class="font-size-sm font-w600 text-uppercase text-white-op">Check Out</div>
                                </div>
                            </a>
                        </div>
                    <div class="col-md-6 col-xl-3">
                            <a class="block block-transparent" href="javascript:void(0)">
                                <div class="block-content block-content-full bg-danger text-center">
                                    <div class="item item-2x item-circle bg-black-op-10 mx-auto mb-20">
                                        <i class="fa fa-close text-danger-light"></i>
                                    </div>
                                    <div class="font-size-h3 font-w600 text-white"><%=totalabsunt %></div>
                                    <div class="font-size-sm font-w600 text-uppercase text-danger-light">Absent</div>
                                </div>
                            </a>
                        </div>
                        <!-- END Row #6 -->
                    </div>

                </div>
            </div>
         </div>
    
     <div class="row ml-15 mr-15 mt-15">
    
         <%=schedule%>

        
    </div>

     

    
     <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
               <div class="block-header block-header-default">
                    <h3 class="block-title">Check In Check Out  Report</h3>
                    
                </div>
                <div class="block-content block-content-full">


                    <%=jobcodereport %>

                    </div>

                </div>

            </div>
         </div>
   
</asp:Content>

