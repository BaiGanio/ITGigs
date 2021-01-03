<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sumator.aspx.cs" Inherits="SumatorDemo.Sumator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Web Forms</title>
</head>
<body>


    <form id="formSumator" runat="server">
        <h1>Sumator</h1>
        First number:
            <asp:TextBox ID="TextBoxFirstNum" runat="server"></asp:TextBox>
        <br />
        <br />
        Second number:
            <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonCalculateSum" runat="server"
            OnClick="ButtonCalculateSum_OnClick" Text="Zvun4 Button"/>
         <br />
        <br />
        Sum:
        <asp:TextBox ID="TextBoxSum" runat="server"></asp:TextBox>
    </form>

</body>
</html>
