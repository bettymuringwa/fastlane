<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="Purchase.aspx.cs" Inherits="abc20025_fastlane.Purchase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Purchases</h1>

     <div class="ban"><a href=#><img src="images\shop.png" ></a>
          </div>


    <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Customer Registration</legend>

        <div id="divcontrols">

             <label for="dob">Date Of Purchase</label>
            <input runat="server"  ClientIDMode="Static" type="date" id="dob" name="dob" />
            <br />

             <label for="time">Time of Purchase </label>
            <input runat="server"  ClientIDMode="Static" type="time" id="time" name="time" />
            <br />

             <label for="customerid"> CustomerID </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="customerid" name="customerid" placeholder="Customerid" oninvalid="setCustomValidity('Please enter your ID number !!')" oninput="setCustomValidity('')" />
            <br />
            
            <label for="product">Product</label>
            <select runat="server" ClientIDMode="Static" id="product" name="product">
                <option value="0">Select...</option>
                <option value="Round Plug">Round Plug</option>
                <option value="Study Desk">Study desk</option>
                 <option value="cereal">cereal</option>
                 <option value="Chairs Black">Chairs Black</option>
                 <option value="Mustard sauce">Mustard sauce</option>
                 <option value="Biscuits Ginger">Biscuits ginger</option>
            </select>
            <br />

            <label for="Quantity">Quantity </label>
           <select runat="server" ClientIDMode="Static" id="quantity" name="quantity">
                <option value="3">3</option>
                <option value="5">5</option>
                <option value="10">10</option>
               </select>
            <br />

            <p>3 PURCHASES = P200 | 5 PURCHASES = P400 | 10 PURCHASES = P800 <br /> PLease select the correct price! </p>

            <label for="price">Price </label>           
           <select runat="server" ClientIDMode="Static" id="price" name="price">
                <option value="200">P200</option>
                <option value="400">P400</option>
               <option value="800">P800</option>
               </select>
            <br />
          
         

            <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />

            <div id="divbuttons">
                <asp:Button ID="btnpurchase" runat="server" ClientIDMode="Static" CssClass="button" Text="Purchase" OnClick="btnpurchase_Click" />
                <input type="reset" ID="btnReset"  value="Clear"/>
            </div>
            <br />

           </div>




   <%-- <script src="http://code.jquery.com/jquery-latest.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            $('.chkbx').click(function () { //click selector checkbox class
                var text = "";
                $('.chkbx:checked').each(function () {
                    text += $(this).val() + ',';
                });
                text = text.substring(0,text.length -1)
            });
            text = text.substring(0, text.length - 1);
            $('#TxtSelected').val(text);
            var count = $("[type='checkbox']:checked").length;
        });
        

    </script>
    

    <asp:Label ID="grocery" runat="server" Text="grocery">Grocery</asp:Label> <br />
    <asp:CheckBox type="checkbox" Class="chkbx" runat="server" value="Beans" />Beans
    <asp:CheckBox type="checkbox" Class="chkbx" runat="server" value="Cereal" /> Cereal
    <asp:CheckBox type="checkbox" Class="chkbx" runat="server" value="Salt" /> Salt
    <asp:CheckBox type="checkbox" Class="chkbx" runat="server" value="Sugar" /> Sugar
    <br />
    <asp:TextBox ID="TxtSelected" runat="server"></asp:TextBox> <br />
     <asp:Button ID="btnpurchase" runat="server" CssClass="button" Text="Purchase" />--%>




           </fieldset>
</div>
        
       
</asp:Content>
