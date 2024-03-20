<%@ Page Language="C#" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="bootstrap_multiselect.js"></script>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                                         <div class="col-sm-3">
													<asp:Label ID="lblapselectteam" runat="server"><i class="icon-users4"></i>&nbsp Select Team</asp:Label>

                                                   <br />
                                                    <asp:ListBox ID="lstFruits" runat="server" CssClass="form-control input-xs border-teal" SelectionMode="Multiple">
  
                                                       <asp:ListItem Text="ABC"></asp:ListItem>
                                                        <asp:ListItem Text="ABC">
                                                       </asp:ListItem>
                                                        <asp:ListItem Text="ABC">
                                                       </asp:ListItem><asp:ListItem Text="ABC">
                                                       </asp:ListItem>
                                                    </asp:ListBox>

									
									

									
												</div>
    </div>
    </form>


    <script type="text/javascript">
        $(function () {
            $('[id*=lstFruits]').multiselect({
                includeSelectAllOption: true
            });
        });
</script>
    
</body>
</html>
