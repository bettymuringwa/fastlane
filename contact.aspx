<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="abc20025_fastlane.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
    <h1>Contacts</h1>

               
<p>

  <b>  FastLane HyperMarket</b> <br>
    Email: fastlane@hypermarket.it <br>
    Location:  Via Marghera, 2 - 00185 Botswana <br>
    Tel: (+39) 06.49711 <br>
    Fax: (+39) 06.4450758 <br>
<br><br><br>

</p>




        <div class="ban"><a href=#><img src="images/help.jpg" alt=""></a> </div>
                   

<br>

      <p>We would love to hear from you and post your stories about your experiences in Gaborone, Botswana. Send your messages to <br>
          <b>fastlane@hypermarket.it</b> or fill in the form below for any enquiries and comments:</p> <br>

          

    <fieldset>
        <legend>Leave us a comment</legend>

          <label for="Comment" >Comment:</label>
          <textarea name="name" rows="8" cols="80" required placeholder="Write Comment..."></textarea>  <br><br>

          <label for="" >Name:</label>
          <input type="text" name="name"  placeholder="Your name..." required > <br><br>

          <label for="email" >Email:</label>
          <input type="email" name="email" placeholder="Your email..." required >
          <br><br>
          
            <asp:Button ID="btnsubmit" runat="server" ClientIDMode="Static" CssClass="button" Text="Submit" OnClick="btnsubmit_Click" />
                 <input type="reset" ID="btnReset"  value="Clear"/>

          <br><br><br>

          </fieldset>       

        </div>

    <br /> <br /> <br /> <br /> <br />

</asp:Content>
