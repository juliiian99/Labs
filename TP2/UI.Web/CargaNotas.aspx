<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaNotas.aspx.cs" Inherits="UI.Web.CargaNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Label ID="cursoLabel1" runat="server" Text="Curso: "></asp:Label>
    <asp:DropDownList ID="cursoDropDownList" runat="server" AutoPostBack="True">
    </asp:DropDownList>
    <asp:Button ID="buscarButton" runat="server" Text="Buscar " OnClick="buscarButton_Click" />
    <br />
    <asp:Panel ID="gridPanel" runat="server">
    <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="IDAlumno" DataField="IDAlumno" />
                <asp:BoundField HeaderText="ID Curso" DataField="IDCurso" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
         </asp:Panel>

    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="idCursoLabel" runat="server" Text="ID Curso: " Visible="False"></asp:Label>
        <asp:DropDownList ID="idCursoDropDownList" runat="server" Visible="False" > </asp:DropDownList>        
        <br />
        <asp:Label ID="condicionLabel" runat="server" Text="Condicion: "></asp:Label>
        <asp:DropDownList ID="condicionDropDownList" runat="server">
            <asp:ListItem>Inscripto</asp:ListItem>
            <asp:ListItem>Libre</asp:ListItem>
            <asp:ListItem>Aprobado</asp:ListItem>
            <asp:ListItem>Cursando</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="notaLabel" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="notaTextBox" runat="server" Width="40px" MaxLength="2"></asp:TextBox>
        <br />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click" CausesValidation="False">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar condicion alumno</asp:LinkButton>
    </asp:Panel>
</asp:Content>
