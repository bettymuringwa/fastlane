<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="logout.aspx.cs" Inherits="abc20025_fastlane.logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>THANK YOU FOR VISITNG US!</p> <br />
     <asp:Button ID="btnlogout" runat="server" ClientIDMode="Static" CssClass="button" style="margin-right:50%;" Text="Log Out" OnClick="btnlogout_Click" />
         


</asp:Content>
