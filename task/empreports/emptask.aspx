<%@ Page Title="" Language="C#" MasterPageFile="~/department/user/user.master" AutoEventWireup="true" CodeFile="emptask.aspx.cs" Inherits="task_empreports_emptask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row ml-15 mr-15 mt-15">
        <div class="col-12">
            <div class="block">
                <div class="block-header block-header-default">
                    <h3 class="block-title">Daily Activity Report</h3>
                </div>
                <div class="block-content block-content-full">
                    <div class="row report_datepicker_row d-sm-block d-none">
                        <div class="col-md-8">
                            <div class="form-group row">
                                <label class="col-md-12 col-3 date_label form-material pt-0 text-md-left text-right" for="example-daterange1">Time Period</label>
                                <div class="col-md-8 col-6 date_picker">
                                    <div class="input-daterange input-group" data-date-format="mm/dd/yyyy" data-week-start="1" data-autoclose="true" data-today-highlight="true">
                                        <asp:TextBox ID="txtfromdate" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Date"></asp:TextBox>
                                        <div class="input-group-prepend input-group-append">
                                            <span class="input-group-text font-w600">to</span>
                                        </div>
                                        <asp:TextBox ID="txttodate" class="form-control" runat="server" name="wizard-simple2-firstname" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-3 col-3 sub_btn">
                                    <button type="submit" class="btn btn-alt-primary">Submit</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- DataTables functionality is initialized with .js-dataTable-full class in js/pages/be_tables_datatables.min.js which was auto compiled from _es6/pages/be_tables_datatables.js -->
                    <table class="table table-bordered table-striped table-vcenter js-dataTable-full scroll_row_tabel">
                        <thead>
                            <tr>
                                <th class="text-center">ID</th>
                                <th>Name</th>
                                <th class="d-none d-sm-table-cell">Email</th>
                                <th class="d-none d-sm-table-cell" style="width: 15%;">Access</th>
                                <th class="text-center" style="width: 15%;">Profile</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class="text-center">1</td>
                                <td class="font-w600">Bhoomika Chudasama</td>
                                <td class="d-none d-sm-table-cell">customer1@example.com</td>
                                <td class="d-none d-sm-table-cell">
                                    <span class="badge badge-warning">Trial</span>
                                </td>
                                <td class="text-center">
                                    <button type="button" class="btn btn-sm btn-secondary" data-toggle="tooltip" title="View Customer">
                                        <i class="fa fa-user"></i>
                                    </button>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <!-- END Dynamic Table Full -->
        </div>
    </div>
</asp:Content>

