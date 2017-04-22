<%@ Page Title="" Language="C#" MasterPageFile="~/views/PageMaster.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplicationASPClasic.views.usuario.update" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Editar Usuario</h1>
    <section class="row">
        <div class="col-sm-4">

          
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:HiddenField ID="id_usuario" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="label">Nombre:</asp:Label>
                        <asp:TextBox ID="nombre" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="label">Apellido paterno:</asp:Label>
                        <asp:TextBox ID="ap_pat" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="label">Apellido materno:</asp:Label>
                        <asp:TextBox ID="ap_mat" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="label">Email:</asp:Label>
                        <asp:TextBox ID="email" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="label">Teléfono:</asp:Label>
                        <asp:TextBox ID="phone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label6" runat="server" Text="label">Usuario:</asp:Label>
                        <asp:TextBox ID="usu" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label7" runat="server" Text="label">Password:</asp:Label>
                        <asp:TextBox ID="pw" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label8" runat="server" Text="label">Activo:</asp:Label>
                        <asp:CheckBox ID="chk_activo" runat="server" Checked="true"/>
                    </div>
                    <asp:Button ID="btn_update" runat="server" Text="Editar"  CssClass="btn btn-warning btn-block" OnClick="btn_create_Click"/>
                </div>
           

        </div>
    </section>
</asp:Content>
