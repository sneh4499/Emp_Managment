<%@ Page Title="" Language="C#" MasterPageFile="~/department/admin/admin.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="task_employee_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="row mr-15 ml-15 mt-15 ">
        <div class="block-header block-header-default w-100 mr-15 ml-15 mb-20">
            <h3 class="block-title">View Employee</h3>
            <div class="row">
                <div class="col-md-9">
                    <asp:TextBox ID="txtsearch" runat="server" CssClass="form-control"></asp:TextBox>
                     
                </div>
                 <div class="col-md-3">
                     <asp:Button ID="btnsearch" Text="Search" AutoPostBack="true" runat="server" CssClass="btn btn-primary" OnClick="btnsearch_Click" />
                     </div>
            </div>
            
           &nbsp&nbsp&nbsp 
             <div class="float-left">
                           &nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp  <Button ID="btnexport" runat="server" CausesValidation="false" class="btn btn-success" onserverclick="btnexport_ServerClick">
                        <i class="fa fa-download mr-5"></i>
               
                         </Button>
                    </div>
        </div>
     

         
             
                        <%=emp%>
                 
         
        
       
           
        <asp:GridView ID="grdexp" Visible="false" runat="server" CssClass="table-responsive" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="datetime" HeaderText="date" SortExpression="datetime" />
               
                <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
                <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
                 <asp:BoundField DataField="fathername" HeaderText="Father Name" SortExpression="fathername" />
                <asp:BoundField DataField="mothername" HeaderText="Mother Name" SortExpression="mothername" />
                <asp:BoundField DataField="uanno" HeaderText="Unono" SortExpression="uanno" />
                <asp:BoundField DataField="esicno" HeaderText="Esicno" SortExpression="esicno" />
                <asp:BoundField DataField="department" HeaderText="Department" SortExpression="department" />
                <asp:BoundField DataField="subdept" HeaderText="Sub Department" SortExpression="subdept" />
                <asp:BoundField DataField="designation" HeaderText="Designation" SortExpression="designation" />
                <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField DataField="mobileno" HeaderText="Mobileno" SortExpression="mobileno" />
                <asp:BoundField DataField="emergencyno" HeaderText="Emergencyno" SortExpression="emergencyno" />
                <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" />
                <asp:BoundField DataField="weight" HeaderText="Weight" SortExpression="weight" />
                <asp:BoundField DataField="height" HeaderText="Height" SortExpression="height" />
                <asp:BoundField DataField="bloodgroup" HeaderText="Bloodgroup" SortExpression="bloodgroup" />
                <asp:BoundField DataField="noofchildren" HeaderText="No Of Children" SortExpression="noofchildren" />
                <asp:BoundField DataField="idmark" HeaderText="Id Mark" SortExpression="idmark" />
                <asp:BoundField DataField="policestation" HeaderText="Policestation" SortExpression="policestation" />
                <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                <asp:BoundField DataField="pincode" HeaderText="Pincode" SortExpression="pincode" />
                <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
                <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                <asp:BoundField DataField="country" HeaderText="Country" SortExpression="country" />
                <asp:BoundField DataField="remark" HeaderText="Remark" SortExpression="remark" />
                <asp:BoundField DataField="qualification" HeaderText="Qualification" SortExpression="qualification" />
                <asp:BoundField DataField="passingyear" HeaderText="Passing year" SortExpression="passingyear" />
                <asp:BoundField DataField="persentage" HeaderText="Persentage" SortExpression="persentage" />
                <asp:BoundField DataField="expicompanyname" HeaderText="expicompanyname" SortExpression="expicompanyname" />
                <asp:BoundField DataField="expidesignation" HeaderText="expidesignation" SortExpression="expidesignation" />
                <asp:BoundField DataField="expiduration" HeaderText="expiduration" SortExpression="expiduration" />
                <asp:BoundField DataField="bankname" HeaderText="Bankname" SortExpression="bankname" />
                <asp:BoundField DataField="accountno" HeaderText="Accountno" SortExpression="accountno" />
                <asp:BoundField DataField="ifsccode" HeaderText="Ifsccode" SortExpression="ifsccode" />
                <asp:BoundField DataField="uploadby" HeaderText="uploadby" SortExpression="uploadby" />
               
               
                <asp:BoundField DataField="pfnumber" HeaderText="pfnumber" SortExpression="pfnumber" />
            </Columns>
        </asp:GridView>
          
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [employee]"></asp:SqlDataSource>
          
    </div>

  
</asp:Content>

