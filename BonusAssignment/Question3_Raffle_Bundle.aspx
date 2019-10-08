<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question3_Raffle_Bundle.aspx.cs" Inherits="BonusAssignment.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ruffle Bundle</h1>
            <p>Please enter the amount of tickets you wish to purchase ($0.25 each)</p>
            <div>
                <asp:TextBox runat="server" ID="tickets_amount" ></asp:TextBox>
                <asp:CompareValidator runat="server" ID="above_zero_validator" controltovalidate="tickets_amount" valuetocompare="0" operator="GreaterThan" type="Integer" errormessage="The ticket amount should be above zero" ></asp:CompareValidator>
            </div>
            <asp:Button runat="server" ID="submit" Text="submit" />
            <div id="purchase_summary" runat="server"></div>
        </div>
    </form>
</body>
</html>
