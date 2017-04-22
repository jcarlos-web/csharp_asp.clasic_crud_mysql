<%@ Page Title="" Language="C#" MasterPageFile="~/views/PageMaster.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplicationASPClasic.views.usuario.editar" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-sm-4">
                <h1>Editar usuario</h1>
                <div class="form-horizontal">
                        <asp:HiddenField ID="id" runat="server" />
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Apellido paterno:"></asp:Label>
                        <asp:TextBox ID="txtAp_pat" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Apellido materno:"></asp:Label>
                        <asp:TextBox ID="txtAp_mat" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Teléfono:"></asp:Label>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox ID="txtUsu" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label7" runat="server" Text="Password:"></asp:Label>
                        <asp:TextBox ID="txtPw" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label8" runat="server" Text="Activo:"></asp:Label>
                        <asp:CheckBox ID="chk_estado" runat="server" />
                    </div>
                    <asp:Button ID="btn_update" runat="server" Text="Editar" CssClass="btn btn-warning btn-block" OnClick="btn_update_Click" />
                </div>
            </div>
    </div>



</asp:Content>
