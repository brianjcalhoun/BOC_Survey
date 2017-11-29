<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="HomePage.aspx.cs" Inherits="Web_Form_Survey.HomePage" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">

<div>
    <h1>Welcome to the BOC Insurance survey website!</h1>
</div>
<hr />
<div>
    <h3>With this website you will be able to create a custom survey to suit your needs.</h3>
    <asp:HyperLink ID="HyperLink1" runat="server" href="/QuestionMaintenance"><h3>Get Started Now!</h3></asp:HyperLink>  
</div>


</asp:Content>
