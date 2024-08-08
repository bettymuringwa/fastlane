<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="registers.aspx.cs" Inherits="abc20025_fastlane.registers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">

        <h1>Customer Registration</h1>

    <div class=""><a href=#><img src="images\rewards.jpg" style="width:150px; height:150px; 
                                                        margin-left:auto; margin-right:auto;" ></a>
          </div>

    <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Customer Registration</legend>

        <div id="divcontrols">
             <label for="customerid"> CustomerID </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="customerid" name="customerid" placeholder="Customerid" oninvalid="setCustomValidity('Please enter your ID number !!')" oninput="setCustomValidity('')" />
            <br />
            
            <label for="firstname">Firstname </label>
            <input type="text" runat="server" ClientIDMode="Static" id="firstname" name="firstname" placeholder="Firstname" oninvalid="setCustomValidity('Please enter the user firstname !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="surname">Surname </label>
            <input type="text" runat="server" ClientIDMode="Static" id="surname" name="surname" placeholder="Surname" oninvalid="setCustomValidity('Please enter the user surname !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="gender">Gender </label>
            <select runat="server" ClientIDMode="Static" id="gender" name="gender">
                <option value="0">Select...</option>
                <option value="F">Female</option>
                <option value="M">Male</option>
            </select>
            <br />

            <label for="dob">Date Of Birth </label>
            <input runat="server"  ClientIDMode="Static" type="date" id="dob" name="dob" />
            <br />

            <label for="country">Country </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="country" name="country" placeholder="Country" oninvalid="setCustomValidity('Please enter a valid user email !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="town">Town </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="town" name="town" placeholder="Town" oninvalid="setCustomValidity('Please enter a valid user email !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="customeraddress"> Address </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="customeraddress" name="customeraddress" placeholder=" Address" oninvalid="setCustomValidity('Please enter the user physical address !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="email">Email Address </label>
            <input runat="server"  ClientIDMode="Static" type="email" id="email" name="email" placeholder="Email" oninvalid="setCustomValidity('Please enter a valid user email !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="cellno">Cell Number </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="cellno" name="cellno" placeholder="Cell Number" oninvalid="setCustomValidity('Please enter the user cell number !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="bankname">Bank Name </label>
               <select runat="server" ClientIDMode="Static" id="bank" name="bank">
                <option value="FNB">FNB</option>
                  <option value="ABSA">ABSA</option>
                  <option value="STANBIC BANK">STANBIC BANK</option>
                  <option value="BARCLAYS">BARCLAYS</option>
                  <option value="BANC ABC">BANC ABC</option>
                </select>
            <br />

             <label for="accountnum">Account Number </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="accountnum" name="accountnum" placeholder="Account Number " oninvalid="setCustomValidity('Please enter the user cell number !!')" oninput="setCustomValidity('')" />
            <br />

            <%--customer status set to a fixed value--%>
             <label for="customerstatus">Customer Status </label>
            <select runat="server" ClientIDMode="Static" id="customerstatus" name="customerstatus">     
                <option value="Active">Active</option>
                </select>
           <br />

            <label for="password">Password </label>
            <input runat="server"  ClientIDMode="Static" type="password" id="password" name="password" placeholder="Password" oninvalid="setCustomValidity('Please enter the user password !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="groupname">User Group </label>
            <select runat="server" ClientIDMode="Static" id="groupname" name="groupname">    
                 <option value="CM">Customer</option>
           </select> 
            <br />    
            
           <%-- <label for="groupid">User Group </label>
            <asp:DropDownList ID="groupid" runat="server"></asp:DropDownList>
            <br />--%>

            <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br />

            <div id="divbuttons">
                <asp:Button ID="btnregister" runat="server" ClientIDMode="Static" CssClass="button" Text="Register" OnClick="btnregister_Click" />
                <input type="reset" ID="btnReset"  value="Clear"/>
            </div>
            <br />

           

        </div>

    </fieldset>
        </div>

</asp:Content>
