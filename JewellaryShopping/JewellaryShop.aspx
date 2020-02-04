<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JewellaryShop.aspx.cs" Inherits="JewellaryShopping.JewellaryShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table  Align="Center" border="0" style="background-image:url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMON-caMuxhR7gyRfQFzwZtrmoZbtJzPoq3ajY_KIFiQyb0e6l&s" >
                   
               <tr>  
                  <td colspan="2" Align="Center" > <b>Registration form</b></td>
                      
                </tr>
                <tr>  
                    <td>User Id :</td>  
                    <td>  
                        <asp:TextBox ID="userId" runat="server" placeholder="User Id"  style="background-color:aliceblue"></asp:TextBox>  
                        <%--<td><asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="TxtName" ErrorMessage="Name required"></asp:RequiredFieldValidator></td>--%>
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="password" runat="server" placeholder=" password" style="background-color:aliceblue"></asp:TextBox></td>
                    <%--<td><asp:RequiredFieldValidator runat="server" ID="rvfPassword" ControlToValidate="TxtPassword" ErrorMessage="Password required"></asp:RequiredFieldValidator></td>--%>
                </tr>  
                <tr>  
                    <td>Confirm Password</td>  
                    <td>  
                        <asp:TextBox ID="conformPassword" runat="server" placeholder="Re-Enter the password"   style="background-color:aliceblue"></asp:TextBox>
                        <%--<td><asp:RequiredFieldValidator runat="server" ID="rvfConfirmPassword" ControlToValidate="TxtConfirmPassword" ErrorMessage="Confirm Password required"></asp:RequiredFieldValidator></td>
                    <td><asp:CompareValidator ControlToValidate="TxtConfirmPassword" ControlToCompare="TxtPassword" ErrorMessage="Password doesn't match" ID="cmpPassword" runat="server"></asp:CompareValidator></td>--%>
                    </td>  
                </tr> 
                   

                <tr>  
                    <td>Phone</td>  
                    <td>
                        <asp:TextBox ID="phone" runat="server" placeholder="Phone number"  style="background-color:aliceblue"></asp:TextBox>
                         <%--<td><asp:RequiredFieldValidator runat="server" ID="rvfPhoneNumber" ControlToValidate="TxtPhone" ErrorMessage="Phone number required"></asp:RequiredFieldValidator></td>--%>
                       
                    </td>
                </tr>  
                
                <tr>  
                    <td>Gmail</td>  
                    <td>  
                        <asp:TextBox ID="mail" runat="server" placeholder ="Mail ID" TextMode="Email" style="background-color:aliceblue"></asp:TextBox>  
                         <%--<td><asp:RequiredFieldValidator runat="server" ID="rvfEmail" ControlToValidate="TxtEmail" ErrorMessage="Email required"></asp:RequiredFieldValidator></td>--%>
                    </td>  
                </tr>  
                 <tr>  
                    <td>Role</td>  
                    <td>  
                        <asp:RadioButtonList ID="ButtonRadio" runat="server" AutoPostBack="true">
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>User</asp:ListItem>
                        </asp:RadioButtonList>

                    </td>  
                </tr>  
                <tr>  
                    <td colspan="2" Align="Center">  
                        <asp:Button text="SignUp" runat="server" ID="btnSubmit"  style="background-color:aliceblue" onclick="OnClick"/></td>
                     
                </tr>  
            </table>
        </div>
    </form>
</body>
</html>
