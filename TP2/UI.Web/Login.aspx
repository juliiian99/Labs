<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title></title>

     <style type="text/css">
         .auto-style1 {
             width: 193px;
         }
         .auto-style2 {
             width: 189px;
         }
         .auto-style3 {
             width: 193px;
             height: 23px;
         }
         .auto-style4 {
             width: 189px;
             height: 23px;
         }
         .auto-style5 {
             height: 23px;
         }
     </style>
    <link href="~/Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
            <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
            <asp:Button CssClass="btn btn-success" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
            <asp:LinkButton ID="lnkRecordarClave" runat="server" OnClick="lnkRecordarClave_Click">Olvidé mi Clave</asp:LinkButton>

                </td>
            </tr>
        </table>
    </form>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/jquery-3.4.1.js"></script>

</body>

</html>