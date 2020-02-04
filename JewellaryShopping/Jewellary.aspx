<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Jewellary.aspx.cs" Inherits="JewellaryShopping.Jewellary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
             <table  Align="Center" border="0" style="background-image:url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMON-caMuxhR7gyRfQFzwZtrmoZbtJzPoq3ajY_KIFiQyb0e6l&s" >
                   
               <tr>  
                  <td colspan="2" Align="Center" > <b>Registration form</b></td>
                </tr>
                <tr>  
                    <td>User Id :</td>  
                    <td>  
                        <asp:TextBox ID="userId" runat="server" placeholder="User Id"  style="background-color:aliceblue"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="password" runat="server" placeholder=" password" style="background-color:aliceblue"></asp:TextBox></td>  
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
                        <asp:Button text="Login" runat="server" ID="btnSubmit"  style="background-color:aliceblue" onclick="OnClicks"/></td>
                     
                </tr>  
                 
                 </table>
        </div>
    </form>
</body>
</html>
