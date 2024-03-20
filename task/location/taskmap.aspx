<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="taskmap.aspx.cs" Inherits="task_location_map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
   <style>        
        #map {
            height:500px;            
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row ml-15 mr-15 mt-15 taskmap">
        <div class="col-md-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">All Employee live location</h3>
                    <div class="block-options">
                    </div>
                </div>
                <!-- Markers Map Container -->
               <div id="map"></div>
            </div>
        </div>
    </div>

    <%=map %>


   
</asp:Content>

