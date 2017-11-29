<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SurveyMaintenance.aspx.cs" Inherits="Web_Form_Survey.SurveyMaintenance" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <h3>To create a survey, please enter a survey name and select 5 different questions.</h3>
<div>
    <asp:Label ID="lblSurveyName" runat="server" Text="Survey Name"></asp:Label><br />
    <asp:TextBox ID="txtSurveyName" runat="server" Width="275px" ></asp:TextBox>
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidator1" 
        runat="server" 
        controltovalidate="txtSurveyName"
        CssClass="text-danger"
        ErrorMessage="Please enter a name!"
        Display="Dynamic">
    </asp:RequiredFieldValidator>
</div><br />
<div>
    <p><asp:DropDownList ID="ddlQuestion1" runat="server" Height="20px" Width="275px" AutoPostBack="True"></asp:DropDownList></p>
    <p><asp:DropDownList ID="ddlQuestion2" runat="server" Height="20px" Width="275px" AutoPostBack="True"></asp:DropDownList></p>
    <p><asp:DropDownList ID="ddlQuestion3" runat="server" Height="20px" Width="275px" AutoPostBack="True"></asp:DropDownList></p>
    <p><asp:DropDownList ID="ddlQuestion4" runat="server" Height="20px" Width="275px" AutoPostBack="True"></asp:DropDownList></p>
    <p><asp:DropDownList ID="ddlQuestion5" runat="server" Height="20px" Width="275px" AutoPostBack="True"></asp:DropDownList></p>
</div>
<div>
    <asp:Button ID="btnSave" runat="server" class="btn btn-info" Text="Save" width="90px" height="45px" OnClick="btnSave_Click" />
    <asp:Label ID="lblSurveySave" runat="server" CssClass="text-danger" Text="There must be 5 different questions selected!" Visible="False"></asp:Label>
</div><br /><br />
<hr />
<div>
    <p>After you have saved your completed survey or surveys, it is now ready to taken. </p>
    <asp:Button ID="btnTakeSurvey" runat="server" class="btn btn-info btn-lg" Text="Take Survey" OnClick="btnTakeSurvey_Click" CausesValidation="False" />
</div>
</asp:Content>