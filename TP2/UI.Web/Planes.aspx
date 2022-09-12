<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Especialidad" DataField="Especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNombreTxt" runat="server" ControlToValidate="descripcionTextBox" ErrorMessage="La descripcion no puede estar vacía" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="especialidadDropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="id_especialidad" DataValueField="id_especialidad">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringExpress %>" SelectCommand="SELECT [id_especialidad], [desc_especialidad] FROM [especialidades]"></asp:SqlDataSource>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server">
        </asp:EntityDataSource>
        <br />

        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
        <asp:ValidationSummary ID="nombreValidationSummary" runat="server" DisplayMode="BulletList" ShowSummary="true" HeaderText="Errors: " ForeColor="Red" />
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
</asp:Content>
