<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvidaClave.aspx.cs" Inherits="UI.Web.OlvidaClave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 82px;
        }
        .auto-style2 {
            width: 296px;
        }
        .auto-style3 {
            width: 82px;
            height: 23px;
        }
        .auto-style4 {
            width: 296px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
    <body>
        <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    </td>
                <td class="auto-style5">
            <asp:Label ID="lblRecuperar" runat="server" Text="Recuperar contraseña" Font-Bold="True" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Font-Underline="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
            <asp:Label ID="lblUsuario" runat="server" Text="Ingrese su usuario"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblNuevaContraseña" runat="server" Text="Nueva contraseña"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNuevaClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnRecuperarContraseña" runat="server" OnClick="btnRecuperarContraseña_Click" Text="Recuperar contraseña" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        </form>
    </body>
</html>
