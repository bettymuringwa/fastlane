<%@ Page Title="" Language="C#" MasterPageFile="~/homeMaster.Master" AutoEventWireup="true" CodeBehind="StaffRegister.aspx.cs" Inherits="abc20025_fastlane.StaffRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrapper">
        <h1>Staff Register</h1>

    <div class=""><a href=#><img src="images\help.jpg" style="width:150px; height:150px; 
                                                        margin-left:auto; margin-right:auto;" ></a>
          </div>

     <fieldset id="fldsetcontrols" class="clsfieldset">
        <legend>Staff Registration</legend>

        <div id="divcontrols">
          
             <label for="staffid"> StaffID </label>
            <input type="text" runat="server" ClientIDMode="Static" id="staffid" name="staffid" placeholder="Staffid" oninvalid="setCustomValidity('Please enter the Staff ID number !!')" oninput="setCustomValidity('')" />
            <br />
            
            <label for="firstname">Firstname </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="firstname" name="firstname" placeholder="Firstname" oninvalid="setCustomValidity('Please enter the user firstname !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="surname">Surname </label>
            <input type="text" runat="server"  ClientIDMode="Static" id="surname" name="surname" placeholder="Surname" oninvalid="setCustomValidity('Please enter the user surname !!')" oninput="setCustomValidity('')" />
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
            <input runat="server"  ClientIDMode="Static" type="text" id="country" name="country" placeholder="Country" oninvalid="setCustomValidity('Please enter a valid staff country !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="town">Town </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="town" name="town" placeholder="Town" oninvalid="setCustomValidity('Please enter a valid staff email !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="staffaddress"> Address </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="staffaddress" name="staffaddress" placeholder=" Address" oninvalid="setCustomValidity('Please enter the staff physical address !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="email">Email Address </label>
            <input runat="server"  ClientIDMode="Static" type="email" id="email" name="email" placeholder="Email" oninvalid="setCustomValidity('Please enter a valid staff email !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="cellno">Cell Number </label>
            <input runat="server"  ClientIDMode="Static" type="text" id="cellno" name="cellno" placeholder="Cell Number" oninvalid="setCustomValidity('Please enter the staff cell number !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="positionname">Position Name </label>
            <select runat="server"  ClientIDMode="Static" id="positionname" name="positionname">
                 <option value="0">Select...</option>
                 <option value="AA">Accontant</option>
                 <option value="SS">Sales</option>
                 <option value="IT">IT</option>
                 <option value="MM">Manager</option>
            </select>
            <br />
          
            <%--staff status set to a fixed value--%>
             <label for="staffstatus">Staff Status </label>
            <select runat="server" ClientIDMode="Static" id="staffstatus" name="staffstatus">
                   <option value="Active">Active</option>
                <option value="Disabled">Disabled</option>
                </select>
           <br />

            <label for="password">Password </label>
            <input runat="server"  ClientIDMode="Static" type="password" id="password" name="password" placeholder="Password" oninvalid="setCustomValidity('Please enter the user password !!')" oninput="setCustomValidity('')" />
            <br />

            <label for="groupname">User Group </label>
            <select runat="server"  ClientIDMode="Static" id="groupname" name="groupname">
                 <option value="0">Select...</option>
                 <option value="AD">Admin</option>
                 <option value="SF">Staff</option>
            </select>
            <br />   
            
               <label for="picture">Profile Picture </label>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="pic-control" />
          


            <label id="lblupload" name="lblupload" class="info" runat="server" ClientIDMode="Static"></label> 
            <label id="lblerror" name="lblerror" class="info" runat="server" ClientIDMode="Static"></label> 
            <br /> <br /> <br /> 

            <div id="divbuttons">
                <asp:Button ID="btnregister" runat="server" ClientIDMode="Static" CssClass="button" Text="Register" OnClick="btnregister_Click" />
                 <asp:Button ID="btnupdate" runat="server" ClientIDMode="Static" CssClass="button" Text="Update" OnClick="btnupdate_Click" />
                               
                <input type="reset" ID="btnReset" CssClass="button" value="Clear"/>
            </div>
            <br />

           <div id="divgrid">
                <asp:GridView ID="grid" runat="server"></asp:GridView>
            </div>

        </div>

    </fieldset>

        </div>
</asp:Content>
