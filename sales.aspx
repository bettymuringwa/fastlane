<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="abc20025_fastlane.sales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Sales Report</h1>
    <div class="ban"><a href=#><img src="images\sale.jpg" ></a>
          </div>
    <br />

    <h1>Total Transactions</h1>
        <br />
        <p>Below is the total number of transactions made:</p> <br />
    <asp:GridView id="gridusers" ClientIDMode="Static" runat="server"></asp:GridView>

        
        <h1>Total Sales</h1>
        <br />
        <p>Below are the total sales made for each product:</p> <br />
        <asp:GridView id="gridusers2" ClientIDMode="Static" runat="server"></asp:GridView>

     <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />
        </div>

    <br /> <br /> <br /> <br /> <br />
</asp:Content>
