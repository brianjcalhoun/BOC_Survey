<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="QuestionMaintenance.aspx.cs" Inherits="Web_Form_Survey.QuestionMaintenance" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <h3>Here you can create a list of questions for your Survey.</h3>
    <div>
        <asp:Label ID="lblQuestionName" runat="server" Text="New Question"></asp:Label><br />
        <asp:TextBox ID="txtQuestion" runat="server" Width="275px"></asp:TextBox>
        <asp:Label ID="lblValidate" runat="server" CssClass="text-danger" Text="That question already exists!" Visible="False"></asp:Label>
        <asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" 
            runat="server" 
            controltovalidate="txtQuestion" 
            CssClass="text-danger"
            Display="Dynamic"
            ErrorMessage="Please enter a question!"> 
        </asp:RequiredFieldValidator>
    </div>
    <br />
    <div>
        <asp:ListBox ID="lstQuestions" runat="server" Height="200px" Width="275px"></asp:ListBox>
    </div>
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-info" OnClick="btnAdd_Click" Width="90px" Height="45px" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-info wrap" OnClick="btnDelete_Click" Width="90px" Height="45px" CausesValidation="False" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-info wrap" Width="90px" Height="45px" OnClick="btnUpdate_Click" CausesValidation="False" />
    </div>
    <br />
    <br />
    <hr />
    <div>
        <p>Once you have the questions you are satisfied with, you may now create a survey.</p>
        <asp:Button ID="btnCreateSurvey" runat="server" Text="Create Survey" class="btn btn-info btn-lg" OnClick="btnCreateSurvey_Click" CausesValidation="False" />
    </div>
</asp:Content>


