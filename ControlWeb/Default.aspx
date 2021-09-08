<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Ctrl" runat="server" BorderStyle="Dashed" OnDataBinding="Page_Load" Text="Test Border"></asp:Label>
    <asp:CheckBoxList ID="chklst" runat="server">
    </asp:CheckBoxList>
    <asp:Button ID="cmdOK" runat="server" OnClick="cmdOK_Click" Text="Button" />
    <br />
    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>

</asp:Content>
