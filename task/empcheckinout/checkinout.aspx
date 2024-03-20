<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="checkinout.aspx.cs" Inherits="task_empcheckinout_checkinout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
            <h3 class="block-title">Start/Stop Journey</h3>
            <div class="block-options">
            </div>
        </div>
        <div class="block-content block-content-full text-center">
            <div class="row">
                <div class="col-sm-12">
            <asp:Button ID="btncheckin" runat="server" class="btn btn-lg btn-rounded btn-outline-info" Text="Start Journey"  CausesValidation="False" OnClick="btncheckin_Click1" UseSubmitBehavior="False" />
                    
            <div class="col-sm-12">
            <h3><%=data %></h3>    
                <%=tm %>
            </div>
                   <button type="button" runat="server" onclick="myModal" data-target="#myModal" data-wizard="finish" class="btn btn-lg btn-rounded btn-outline-info" data-toggle="modal" id="btnout">Stop Journey</button>
                    </div>
               
                </div>
        </div>
    </div>


    <div aria-labelledby="swal2-title" aria-describedby="swal2-content" class="m-auto swal2-popup swal2-modal swal2-show modal add_emp_modal" id="myModal" tabindex="-1" role="dialog" aria-live="assertive" aria-modal="true">
        <div class="swal2-header">
           
            <img class="swal2-image" style="display: none;"><h2 class="swal2-title" id="swal2-title" style="display: flex;">Send Your Description! </h2>
            <%--<button type="button" class="swal2-close close"  data-dismiss="modal" aria-label="Close this dialog">×</button>--%>
        </div>
        <div class="swal2-content">
            <div id="swal2-content" style="display: block;">Write Description Here..
                <asp:TextBox ID="txtdescription" class="form-control up" required="" runat="server" name="wizard-simple2-firstname" TextMode="MultiLine"></asp:TextBox>
            </div>
            <input class="swal2-input form-control" style="display: none;"><input type="file" class="swal2-file form-control" style="display: none;"><div class="swal2-range form-control" style="display: none;">
                <input type="range">
                <output></output>
            </div>
            <select class="swal2-select form-control" style="display: none;"></select><div class="swal2-radio form-control" style="display: none;"></div>
            <label for="swal2-checkbox" class="swal2-checkbox form-control" style="display: none;">
                <input type="checkbox"><span class="swal2-label"></span></label><textarea class="swal2-textarea form-control" style="display: none;"></textarea><div class="swal2-validation-message" id="swal2-validation-message" style="display: none;"></div>
            <br />
            <label>Upload Image</label>
            <asp:FileUpload ID="fuimg" runat="server" />
        </div>
        <div class="swal2-actions" style="display: flex;">
            <%--<button type="button" class="swal2-confirm btn btn-alt-success m-5" aria-label="" style="display: inline-block;">OK</button>--%>
            <asp:Button ID="btncheckout" runat="server" class="btn btn-lg btn-rounded btn-outline-info" Text="Stop Journey" OnClick="btncheckout_Click1" />
            
             <button type="button" class="swal2-cancel btn btn-alt-danger m-5" aria-label="" style="display: none;">Cancel</button>
        </div>
        <div class="swal2-footer" style="display: none;"></div>
    </div>
</asp:Content>

