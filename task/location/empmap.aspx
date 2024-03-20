<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="empmap.aspx.cs" Inherits="task_location_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>        
        #map {
            height:500px;            
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Map Markers Map -->
    <div class="row ml-15 mr-15 mt-15">
        <div class="col-md-12 mb-15">
            <div class="form-group row">
                <div class="col-lg-12">
                    <div class="form-material">
                        <%--<input type="text" class="js-autocomplete form-control" id="example-autocomplete2" name="example-autocomplete2" placeholder="Employees..">--%>
                        <label for="example-autocomplete2">Employee Search</label>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-12">
            <%=x %>
        </div>
        <div class="col-md-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">All Employee live location</h3>
                    <div class="block-options">
                    </div>
                </div>
                
                
                <div id="map"></div>
            </div>
        </div>
    </div>
    <!-- END Map Markers Map -->

<%--     <script>
        // Initialize and add the map
         function initMap() {
            
            // The value of lat and lng for excet location 
             var emp = { lat: 22.297671, lng: 73.138989 };
              <%=locationheader%>
            // The map, centered at Uluru
            var map = new google.maps.Map(
                document.getElementById('map'), { zoom: 4, center: emp });
            // The marker, positioned at Uluru
            <%=locationdetials%>
        }
    </script>--%>
  <%=locationheader %>
  
</asp:Content>

