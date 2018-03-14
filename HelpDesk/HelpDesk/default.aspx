<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HelpDesk._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
<style type="text/css" media="screen">
    @import "style.css";
</style>
</head>
<body>
  <form id="form1" runat="server">
<asp:PlaceHolder ID="phForm" runat="server" Visible="true">
<div class="row">
<label for="firstName">First Name:</label>    
<asp:TextBox ID="fnameTB" runat="server" />
</div>
<div class="row">
<label for="lastName">Last Name:</label>
<asp:TextBox ID="lnameTB" runat="server" />
</div>
<div class="row">
<label for="email">Email:</label>
<asp:TextBox ID="emailTB" runat="server" />
</div>
<div class="row">
<label for="title">Title:</label>
<asp:TextBox ID="titleTB" runat="server" />
</div>
<div class="row">
<label for="severity">Severity:</label>
<asp:DropDownList ID="ddlSeverity" runat="server" />
</div>
<div class="row">
<label for="status">Status:</label>
<asp:DropDownList ID="ddlStatus" runat="server" />
</div>
<div class="row">
<label for="department">Department:</label>
<asp:DropDownList ID="ddlDept" runat="server" />
</div>
<div class="row">
<label for="summary">Summary:</label>
<asp:TextBox ID="summaryTB" runat="server" TextMode="MultiLine" />
</div>
<div class="row">
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
<input type="reset" value="Reset" />
</div>
</asp:PlaceHolder>
<asp:PlaceHolder ID="phSuccess" runat="server" Visible="false">
<p>Ticket submitted successfully.</p>
<p><a href="Default.aspx">Submit another ticket</a></p>
</asp:PlaceHolder>
</form>
</body>
</html>
