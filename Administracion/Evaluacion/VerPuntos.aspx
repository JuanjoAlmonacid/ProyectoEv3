<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPuntos.aspx.cs" Inherits="Evaluacion.VerPuntos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <span>Cargando Campos...</span>
                </ProgressTemplate>

            </asp:UpdateProgress>


           

            <div>
                <asp:DropDownList ID="puntoDdl" runat="server" Enabled="false"
                    AutoPostBack="true" OnSelectedIndexChanged="nivelDdl_SelectedIndexChanged">
                    <asp:ListItem Value="2430000" Selected="True" Text="Quilpue"></asp:ListItem>
                    <asp:ListItem Value="2340000" Text="Valparaiso"></asp:ListItem>
                    <asp:ListItem Value="2520000" Text="Vinia"></asp:ListItem>
                    <asp:ListItem Value="6500000" Text="VillaAlemana"></asp:ListItem>
                </asp:DropDownList>

                <asp:CheckBox ID="todosChx" Checked="true" runat="server"
                    AutoPostBack="true" OnCheckedChanged="todosChx_CheckedChanged" Text="Ver Todos" />

            </div>

            <div class="mt-5">

                <asp:GridView ID="puntosGrid" runat="server"
                    AutoGenerateColumns="false" CssClass="table table-hover" OnRowCommand="puntosGrid_RowCommand"
                    EmptyDataText="No hay Puntos de estaciones registrados">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre del punto" DataField="Nombre" />
                        <asp:BoundField HeaderText="Ciudad" DataField="CiudadTxt" />
                         <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Sacar del Programa"
                                    CssClass="btn btn-danger" CommandName="eliminar"
                                    CommandArgument='<%# Eval("codigo") %>' />


                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>



            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
