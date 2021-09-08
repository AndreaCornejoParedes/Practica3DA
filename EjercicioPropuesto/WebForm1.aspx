<%@ Page Title="" Language="C#" MasterPageFile="~/principal.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjercicioPropuesto.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box">
        <div class="input">
            <h3 class="title">
                Agregar Pedido
            </h3>
            <!-- Productos -->
            <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>
            <asp:DropDownList ID="Categoria" class="formInput" runat="server" OnSelectedIndexChanged="onSelectCategory" AutoPostBack="True">
                <asp:ListItem Value="0" Selected="True">Seleccione una opción</asp:ListItem>
                <asp:ListItem Value="Comestibles">Comestibles</asp:ListItem>
                <asp:ListItem Value="Informatica">Informatica</asp:ListItem>
                <asp:ListItem Value="Papeleria">Papeleria</asp:ListItem>
                <asp:ListItem Value="Electrodomesticos">Electrodomesticos</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
             <asp:TextBox ID="name" class="formInput" runat="server"></asp:TextBox>
            <asp:Label ID="Label2"  runat="server" Text="Costo(S/.)"></asp:Label>
             <asp:TextBox ID="price" class="formInput" type="number" min="0" step="0.01" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Proveedor"></asp:Label>
            <asp:DropDownList  class="formInput" ID="Proveedor" runat="server">
            </asp:DropDownList>

            <asp:Label ID="Label5" runat="server" Text="Cliente"></asp:Label>
            <asp:DropDownList class="formInput" ID="Cliente" runat="server">
            </asp:DropDownList>


            <asp:Button ID="Sunmit" class="btn" runat="server" Text="Agregar" OnClick="saveData" />
        </div>
        <div class="output">
            <div class="pedidoTitle">
                <h5>Producto</h5>
                <h5>Precio</h5>
                <h5>Proveedor</h5>
            </div>
            
            <asp:Panel ID="Panel1" runat="server">
                <!-- ITEMS -->
            </asp:Panel>
        </div>
    </div>
</asp:Content>
