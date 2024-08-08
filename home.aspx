<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="abc20025_fastlane.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

      <div class="slideshow-container">

    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/shop.png" style="width:100%; height:550px;">
    <div class="text"> <br>  </div>
    </div>

    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/f4.jpg" style="width:100%; height:550px;">
    <div class="text"> <br> </div>
    </div>

    <div class="mySlides fade">
    <div class="captext"></div>
    <img src="images/cl5.jpg" style="width:100%; height:550px;">
    <div class="text"> <br>  </div>
    </div>

    <div style=" ">
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

    <br /> <br />
   

    

        

</asp:Content>
