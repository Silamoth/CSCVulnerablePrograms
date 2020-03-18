<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VulnerableLogin._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Website.com</h1>
        <p class="lead">Welcome to our website!&nbsp; Please login below!</p>
    </div>

    <div class="row" style="font-size: medium">
        <br />
        Username:
        <br />
        <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Password:<br />
        <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" Width="309px" />
        <asp:SqlDataSource ID="dataSource" runat="server" ConnectionString="<%$ ConnectionStrings:LoginConnectionString %>" SelectCommand="SELECT * FROM [LoginTable]"></asp:SqlDataSource>
    </div>

</asp:Content>