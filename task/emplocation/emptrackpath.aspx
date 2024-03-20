<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="emptrackpath.aspx.cs" Inherits="task_emplocation_emptrackpath" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <style>
        /* Always set the map height explicitly to define the size of the div
       * element that contains the map. */
        #map {
            height:500px;
            width: 100%;
        }
        /* Optional: Makes the sample page fill the window. */
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }

        
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <!-- Map Markers Map -->
    <div class="row ml-0 mr-0 mt-15">
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
    <%=map %>
</asp:Content>

