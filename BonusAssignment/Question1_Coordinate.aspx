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
            </div>
            <div>
                <label>y-value</label>
                <asp:TextBox runat="server" ID="yvalue" ></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="submit" Text="submit" />
            <div id="quadrant_summary" runat="server"></div>
        </div>
    </form>
</body>
</html>
