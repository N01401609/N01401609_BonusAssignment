<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question1_Coordinate.aspx.cs" Inherits="BonusAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coordinate</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Coordinate</h1>
            <p>Please input your coordinates below</p>
            <div>
                <label>x-value</label>
                <asp:TextBox runat="server" ID="xvalue" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="xvalue" ErrorMessage="Please enter a value"></asp:RequiredFieldValidator>
                <asp:CompareValidator runat="server" ID="x_not_zero" controltovalidate="xvalue" valuetocompare="0" operator="NotEqual" type="Integer" errormessage="the x value should not be zero" ></asp:CompareValidator>
            </div>
            <div>
                <label>y-value</label>
                <asp:TextBox runat="server" ID="yvalue" ></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="yvalue" ErrorMessage="Please enter a value"></asp:RequiredFieldValidator>
                <asp:CompareValidator runat="server" ID="y_not_zero" controltovalidate="yvalue" valuetocompare="0" operator="NotEqual" type="Integer" errormessage="The y value should not be zero" ></asp:CompareValidator>
            </div>
            <asp:Button runat="server" ID="submit" Text="submit" />
            <div id="quadrant_summary" runat="server"></div>
        </div>
    </form>
</body>
</html>
