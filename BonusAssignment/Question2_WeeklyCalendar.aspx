<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question2_WeeklyCalendar.aspx.cs" Inherits="BonusAssignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calendar                                                             </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Your Weekly Calendar</h1>
            <p> Please select the days of the week you work on</p>
            <asp:CheckBoxList runat="server" ID="work_days" >
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button runat="server" ID="submit" Text="submit" />
            <div id="work_schedule_summary" runat="server"></div>
        </div>
    </form>
</body>
</html>
