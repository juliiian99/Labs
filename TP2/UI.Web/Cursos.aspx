<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="ID Materia" DataField="IDMateria" />
                <asp:BoundField HeaderText="ID Comision" DataField="IDComision" />
                <asp:BoundField HeaderText="Año calendario" DataField="AnioCalendario" />
                <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="materiaLabel" runat="server" Text="Materia: "></asp:Label>
        <asp:DropDownList ID="materiaDropDownList" runat="server" >
        </asp:DropDownList> 
        <br />
        <asp:Label ID="comisionLabel" runat="server" Text="Comision: "></asp:Label>
        <asp:DropDownList ID="comisionDropDownList" runat="server" >
        </asp:DropDownList> 
        <br />
        <asp:Label ID="anioCalendarioLabel" runat="server" Text="Año calendario : "></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvAnioTxt" runat="server" ControlToValidate="anioCalendarioTextBox" ErrorMessage="El año no puede estar vacío" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="cupoLabel" runat="server" Text="Cupo : "></asp:Label>
        <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCupoTxt" runat="server" ControlToValidate="cupoTextBox" ErrorMessage="El cupo no puede estar vacío" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
        <asp:ValidationSummary ID="vs" runat="server" DisplayMode="BulletList" ShowSummary="true" HeaderText="Errors: " ForeColor="Red" />
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>

</asp:Content>
