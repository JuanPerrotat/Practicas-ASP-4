<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejemplo_web_GV.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvAutos" CssClass="table table-bordered table-hover" runat="server" AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
            <asp:BoundField HeaderText="Color" DataField="Color" />
            <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
            <asp:CheckBoxField  HeaderText="Importado" DataField="Importado" />
        </Columns>
    </asp:GridView>

</asp:Content>
