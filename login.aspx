<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="abc20025_fastlane.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="wrapper">
        <h1>Customer Log In</h1>

    <div class=""><a href=#><img src="images\checklist.png" style="width:150px; height:150px; 
                                                        margin-left:auto; margin-right:auto;" ></a>
          </div>

    <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Customer Log In</legend>

    <asp:Label for="username" runat="server" Text="username">Username</asp:Label>
    <input type="text" runat="server" ClientIDMode="Static" id="username" name="username" placeholder="username" oninvalid="setCustomValidity('Please enter your email address !!')" oninput="setCustomValidity('')" />
            <br />    
    <br/>
    <asp:Label runat="server" Text="password">Password</asp:Label> 
    <input type="password" runat="server" ClientIDMode="Static" id="password" name="password" placeholder="password" oninvalid="setCustomValidity('Please enter your password !!')" oninput="setCustomValidity('')" />
            
    <br/>
    <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" CssClass="button" Text="Log In" />
    <asp:Button ID="btnregister" runat="server" OnClick="btnregister_Click" CssClass="button" Text="Register" />
     <input type="reset" ID="btnReset"  value="Clear"/>

    <asp:Label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static" ></asp:Label>

        </fieldset>
        </div>
</asp:Content>
