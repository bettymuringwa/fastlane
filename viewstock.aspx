<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="viewstock.aspx.cs" Inherits="abc20025_fastlane.viewstock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>View Stock</h1>
  <%--  <div class="ban"><a href=#><img src="images\f.jpg" ></a>
          </div>--%>

         <div class="slideshow-container">

    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/fn.jpg" style="width:90%; height:350px;">
    <div class="text"> <br> </div>
    </div>

                    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/f4.jpg" style="width:90%; height:350px;">
    <div class="text"> <br>  </div>
    </div>

    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/cl4.jpg" style="width:90%; height:350px;">
    <div class="text"> <br>  </div>
    </div>
     

               <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/el2.jpg" style="width:90%; height:350px;">
    <div class="text"> <br>  </div>
    </div>

    <div style=" ">
      <span class="dot"></span>
      <span class="dot"></span>
      <span class="dot"></span>
        <span class="dot"></span>
    </div>
    </div>

    <br>

    <!-- java script for slideshow -->
    <script type="text/javascript">
      var slideIndex = 0;
      showSlides();

      function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
       var dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
          slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) {slideIndex = 1}
        for (i = 0; i < dots.length; i++) {
          dots[i].className = dots[i].className.replace(" active", "");
        }
        slides[slideIndex-1].style.display = "block";
        dots[slideIndex-1].className += " active";
        setTimeout(showSlides, 2500); // Change image every 2 seconds
      }

    </script>

    <br /> 
   <h2>Groceries</h2> <br />
    <asp:GridView id="gridusers" ClientIDMode="Static" runat="server"></asp:GridView> <br /> <br />
        

        <h2>Furniture</h2> <br />
    <asp:GridView id="gridf" ClientIDMode="Static" runat="server"></asp:GridView> <br /> <br />

         <h2>Electricals</h2> <br />
    <asp:GridView id="gride" ClientIDMode="Static" runat="server"></asp:GridView> <br /> <br />

          <h2>Clothes</h2> <br />
    <asp:GridView id="gridc" ClientIDMode="Static" runat="server"></asp:GridView> <br /> <br />



     <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />

        </div>
</asp:Content>
