<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPunto.aspx.cs" Inherits="Evaluacion.AgregarPunto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
    </div>

    <div class="card">
        <div class="card-header bg-primary text-white">
            Ingresar Punto
        </div>
        <div class="card-body">
            <div class="form-group">
                <label for="nombreTxt">Nombre de punto</label>
                <asp:TextBox ID="nombreTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Debe ingresar el nombre de punto" CssClass="text-danger"
                    ControlToValidate="nombreTxt"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label for="codigoTxt">Codigo</label>
                <asp:TextBox ID="codigoTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="codigoCV" runat="server" ErrorMessage="CustomValidator"
                    CssClass="text-danger" ControlToValidate="codigoTxt"
                    OnServerValidate="codigoCV_ServerValidate" ValidateEmptyText="true"></asp:CustomValidator>
            </div>

            <div class="form-group">
                <label for="puntoDdl">Sector de punto</label>
                <asp:DropDownList ID="puntoDdl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />
            <div class="form-group">
                <label for="nivelRbl">Ciudad</label>
                <asp:RadioButtonList ID="nivelRbl" runat="server" CssClass="form-control">
                    <asp:ListItem Value="2430000" Selected="True" Text="Quilpue"></asp:ListItem>
                    <asp:ListItem Value="2340000" Text="Valparaiso"></asp:ListItem>
                    <asp:ListItem Value="2520000" Text="Vinia"></asp:ListItem>
                    <asp:ListItem Value="6500000" Text="VillaAlemana"></asp:ListItem>
                </asp:RadioButtonList>
            </div>

        </div>

        <asp:Button ID="ingresarBtn" runat="server" Text="Crear Punto"
            CssClass="btn btn-dark" OnClick="ingresarBtn_Click" />


    </div>
</asp:Content>
