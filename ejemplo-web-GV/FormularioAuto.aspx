<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormularioAuto.aspx.cs" Inherits="ejemplo_web_GV.FormularioAuto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtID" class="form-label">ID</label>
                <asp:TextBox ID="txtID" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtModelo" class="form-label">Modelo</label>
                <asp:TextBox ID="txtModelo" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="ddlColores" class="form-label">Color</label>
                <asp:DropDownList ID="ddlColores" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtFecha" class="form-label">Fecha</label>
                <asp:TextBox ID="txtFecha" TextMode="Date" CssClass="form-control" runat="server" />
            </div>
            <asp:CheckBox Text="" ID="chkUsado" runat="server" />
            <asp:Label Text="Usado" CssClass="form-check-label" runat="server" />
            <div class="mb-3">
                <asp:RadioButton ID="rbtnImportado" AutoPostBack="true" OnCheckedChanged="rbtnImportado_CheckedChanged" Text="Importado" runat="server" GroupName="Origen" />
                <asp:RadioButton ID="rbtnNacional" AutoPostBack="true" OnCheckedChanged="rbtnImportado_CheckedChanged" Text="Nacional" Checked="true" runat="server" GroupName="Origen" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>

</asp:Content>
