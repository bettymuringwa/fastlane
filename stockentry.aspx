<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="stockentry.aspx.cs" Inherits="abc20025_fastlane.stockentry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Stock Entry</h1>
    <div class="ban"><a href=#><img src="images\f.jpg" ></a>
          </div>

     <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Stock Entry</legend> 

        <div id="divcontrols">
             <label for="pcode"> Productcode </label>
            <input type="text" runat="server" required ClientIDMode="Static" id="pcode" name="pcode" placeholder="Product Code" oninvalid="setCustomValidity('Please enter product code  !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="pname"> Product Name </label>
            <input type="text" runat="server" required ClientIDMode="Static" id="pname" name="pname" placeholder="Product Name" oninvalid="setCustomValidity('Please enter productname !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="size"> Size </label>
            <input type="text" runat="server" required ClientIDMode="Static" id="size" name="size" placeholder="Size" oninvalid="setCustomValidity('Please enter Size !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="categoryid"> CategoryID </label>
            <select runat="server" ClientIDMode="Static" id="categoryid" name="categoryid">   
                 <option value="0">Select...</option>
                 <option value="GR">Grocery</option>
                 <option value="EL">Electricals</option>
                 <option value="FR">Farming</option>
                 <option value="FN">Furniture</option>
                 <option value="MT">Motoring</option>
                 <option value="CH">Chemicals</option>
                 <option value="CL">Clothing</option>
           </select>
            <br />     

            <label for="quantity"> Quantity </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="quantity" name="quantity" placeholder="quantity" oninvalid="setCustomValidity('Please enter Quantity  !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="rlevel"> Reorder Level </label>
            <input type="text" runat="server" ClientIDMode="Static" id="rlevel" name="rlevel" placeholder="Reorder Level" oninvalid="setCustomValidity('Please enter Reorder Level  !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="pprice"> Purchase Price </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="pprice" name="pprice" placeholder="Purchase Price" oninvalid="setCustomValidity('Please enter Purchase Price !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="pmarkup"> Percentage Markup </label>
            <input type="text" runat="server" ClientIDMode="Static" id="pmarkup" name="pmarkup" placeholder="Percentage markup" oninvalid="setCustomValidity('Please enter Percentage markup !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="sprice"> Selling Price </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="sprice" name="sprice" placeholder="Selling Price" oninvalid="setCustomValidity('Please enter Selling Price !!')" oninput="setCustomValidity('')" />
            <br />
            <label for="dpurchase"> Date Purchased </label>
             <input runat="server"  ClientIDMode="Static" type="date" id="dpurchase" name="dpurchase" />
            <br />
            <label for="pstatus"> Product Status </label>
            <select runat="server" ClientIDMode="Static" id="pstatus" name="pstatus">
                <option value="Active">Active</option>
                <option value="Discontinued">Discontinued</option>
                </select> <br />
            <label for="staffid"> StaffID </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="staffid" name="staffid" placeholder="Staff ID" oninvalid="setCustomValidity('Please enter Staff ID  !!')" oninput="setCustomValidity('')" />
            <br />
             
               <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />

            <div id="divbuttons">
                <asp:Button ID="btnsave" runat="server" ClientIDMode="Static" CssClass="button" Text="Save Item" OnClick="btnsave_Click"  />
                  <asp:Button ID="btnupdate" runat="server" ClientIDMode="Static" CssClass="button" Text="Update Item" OnClick="btnupdate_Click"  />               
                
                
                <input type="reset" ID="btnReset"  value="Clear"/>
            </div>
            <br />

            <div id="divgrid">
                <asp:GridView ID="grid" runat="server"></asp:GridView>
            </div>

        </div>

    </fieldset>

        </div>
</asp:Content>
