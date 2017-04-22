<%@ Page Title="" Language="C#" MasterPageFile="~/views/PageMaster.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplicationASPClasic.views.usuario.delete" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Eliminar Usuario?</h1>
    <section class="row">
        <div class="col-sm-4">

            <asp:PlaceHolder ID="PlaceHolderDelete" runat="server">
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:HiddenField ID="id_usuario" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="nombre" runat="server" Text="Nombre"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="ap_pat" runat="server" Text="Apellido paterno"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="ap_mat" runat="server" Text="Apellido materno"></asp:Label>
                    </div>

                    <asp:Button ID="btn_delete" runat="server" Text="Eliminar"  CssClass="btn btn-danger btn-block" OnClick="btn_create_Click"/>
                </div>
            </asp:PlaceHolder>
          
        </div>
    </section>

</asp:Content>
