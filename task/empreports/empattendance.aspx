﻿<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="empattendance.aspx.cs" Inherits="task_empreports_empattendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
            <h3 class="block-title">Attendance</h3>
            <div class="block-options">
            </div>
        </div>
        <div class="block-content block-content-full text-center">
            <!-- Bars Chart Container -->
            <canvas class="js-chartjs-bars"></canvas>
        </div>
    </div>
</asp:Content>

