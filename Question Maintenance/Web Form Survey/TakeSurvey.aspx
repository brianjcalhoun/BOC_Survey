<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TakeSurvey.aspx.cs" Inherits="Web_Form_Survey.TakeSurvey" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
<h3>Select a survey from the list and answer the questions then hit the submit button.</h3>
<div>
    <asp:DropDownList ID="ddlSurveyList" runat="server" Height="20px" Width="275px" 
        OnSelectedIndexChanged="ddlSurveyList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
</div>
<br>
<div>
    <asp:Label RepeatDirection="Horizontal" ID="lblQuestion1" runat="server" Visible="False"></asp:Label>
    <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList1" runat="server" Visible="False">
        <asp:ListItem Text="Agree &nbsp&nbsp" Value="Agree" Selected="False" />
        <asp:ListItem Text="Disagree &nbsp&nbsp" Value="Disagree" Selected="False" />
        <asp:ListItem Text="N/A &nbsp" Value="N/A" Selected="False" />
    </asp:RadioButtonList><br />
    <asp:Label ID="lblQuestion2" runat="server" Visible="False"></asp:Label>
        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList2" runat="server" Visible="False">
        <asp:ListItem Text="Agree &nbsp&nbsp" Value="Agree" Selected="False" />
        <asp:ListItem Text="Disagree &nbsp&nbsp" Value="Disagree" Selected="False" />
        <asp:ListItem Text="N/A &nbsp" Value="N/A" Selected="False" />
    </asp:RadioButtonList><br />
    <asp:Label ID="lblQuestion3" runat="server" Visible="False"></asp:Label>
        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList3" runat="server" Visible="False">
        <asp:ListItem Text="Agree &nbsp&nbsp" Value="Agree" Selected="False" />
        <asp:ListItem Text="Disagree &nbsp&nbsp" Value="Disagree" Selected="False" />
        <asp:ListItem Text="N/A &nbsp" Value="N/A" Selected="False" />
    </asp:RadioButtonList><br />
    <asp:Label ID="lblQuestion4" runat="server" Visible="False"></asp:Label>
        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList4" runat="server" Visible="False">
        <asp:ListItem Text="Agree &nbsp&nbsp" Value="Agree" Selected="False" />
        <asp:ListItem Text="Disagree &nbsp&nbsp" Value="Disagree" Selected="False" />
        <asp:ListItem Text="N/A &nbsp" Value="N/A" Selected="False" />
    </asp:RadioButtonList><br />
    <asp:Label ID="lblQuestion5" runat="server" Visible="False"></asp:Label>
        <asp:RadioButtonList RepeatDirection="Horizontal" ID="RadioButtonList5" runat="server" Visible="False">
        <asp:ListItem Text="Agree &nbsp&nbsp" Value="Agree" Selected="False" />
        <asp:ListItem Text="Disagree &nbsp&nbsp" Value="Disagree" Selected="False" />
        <asp:ListItem Text="N/A &nbsp" Value="N/A" Selected="False" />
    </asp:RadioButtonList><br />
</div><br />
<hr />
<div>
    <p>Once you have answered all the questions, hit submit to save your results to the database!</p>
    <asp:Button ID="btnSubmit" runat="server" class="btn btn-info btn-lg" OnClick="btnSubmit_Click" Text="Submit" Width="91px" />
    <asp:Label 
        ID="lblSaved" 
        runat="server" 
        Text="Your Survey has been saved. To take another, please select one from the list." 
        ForeColor="Green" 
        Visible="False">
    </asp:Label>

</div>
</asp:Content>