<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="viewpurchases.aspx.cs" Inherits="abc20025_fastlane.viewpurchases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div class="wrapper">
        <h1>View Purchases</h1>
     <div class="ban"><a href=#><img src="images\f1.jpg" ></a>
          </div>

        <h2>Your purchase history:</h2> <br />
     <asp:GridView id="gridusers" ClientIDMode="Static" runat="server"></asp:GridView> 

    

     <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />
        </div>
</asp:Content>
