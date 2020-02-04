<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewPage.aspx.cs" Inherits="JewellaryShopping.UserViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMON-caMuxhR7gyRfQFzwZtrmoZbtJzPoq3ajY_KIFiQyb0e6l&s">
    <form id="form3" runat="server" >
        <div >
           <h1><marquee> Sri Mathre Jewellers</marquee></h1>
            <table  Align="Center" border="0">
                   
              <tr>  
                    <td Align="Center">  
                        <asp:Button text="SignUp" runat="server" ID="btnSubmit"  style="background-color:aliceblue" onclick="OnClick"/></td>
                     
                
                 
                    <td  Align="Center">  
                        <asp:Button text="Login" runat="server" ID="Button1"  style="background-color:aliceblue" onclick="OnClick"/></td>
                     
             </tr> 
            </table>
        </div>
    </form>
</body>
</html>
