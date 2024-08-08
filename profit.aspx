<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="profit.aspx.cs" Inherits="abc20025_fastlane.profit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Profit Analysis</h1>
    <div class="ban"><a href=#><img src="images\calc.jpg" ></a>
          </div>
    <br />

        <asp:Label ID="profitanalysis" runat="server" Text="Profit Analysis"></asp:Label>
    <asp:GridView id="gridusers" ClientIDMode="Static" runat="server"></asp:GridView>
     

     <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />
        </div>
    <br /> <br /> <br /> <br /> <br />

</asp:Content>
