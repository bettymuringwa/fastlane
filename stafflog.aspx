﻿<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="stafflog.aspx.cs" Inherits="abc20025_fastlane.stafflog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Staff Log In</h1>
    <div class=""><a href=#><img src="images\help.jpg" style="width:200px; height:190px; 
                                                        margin-left:auto; margin-right:auto;" ></a>
          </div>

    <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Staff Log In</legend>

    <asp:Label for="username" runat="server" Text="username">Username</asp:Label>
    <input type="text" runat="server" ClientIDMode="Static" id="username" name="username" placeholder="username" oninvalid="setCustomValidity('Please enter your email address !!')" oninput="setCustomValidity('')" />
            <br />    
    <br/>
    <asp:Label runat="server" Text="password">Password</asp:Label> 
    <input type="password" runat="server" ClientIDMode="Static" id="password" name="password" placeholder="password" oninvalid="setCustomValidity('Please enter your password !!')" oninput="setCustomValidity('')" />
            
    <br/>
    <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" CssClass="button" Text="Log In" />
     <input type="reset" ID="btnReset"  value="Clear"/>
        
        <asp:Label id="lblerror" name="lblerror" runat="server" ClientIDMode="Static" ></asp:Label>

        </fieldset>
     
        </div>

</asp:Content>
