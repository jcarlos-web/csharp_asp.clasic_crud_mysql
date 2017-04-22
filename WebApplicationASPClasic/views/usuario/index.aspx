<%@ Page Title="" Language="C#" MasterPageFile="~/views/PageMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplicationASPClasic.views.usuario.index" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <h1>Listado de Usuario</h1>

    <section class="row">
        <a href="crear.aspx" title="Agregar nuevo usuario" class="btn btn-info btn-sm">Agregar</a>
        <br />
        <br />
            <asp:ListView ID="list_usuario" runat="server">
                <LayoutTemplate>
                    <div class="table-resposive">
                        <table class="table table-bordered table-striped table-hover">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th colspan="2">Acción</th>
                                    <th>Nombre</th>
                                    <th>Apellido paterno</th>
                                    <th>Apellido materno</th>
                                    <th>Email</th>
                                    <th>Teléfono</th>
                                    <th>Usuario</th>
                                    <th>Password</th>
                                    <th>Estado</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </div>
                </LayoutTemplate>

                <ItemTemplate>
                    <tr>
                        <td><%# Eval("id_usuario") %></td>
                        <td><a href="update.aspx?_query=<%# Eval("id_usuario") %>" title="Editar usuario" role="button" class="btn btn-warning btn-sm">Editar</a></td>
                        <td><a href="delete.aspx?query=<%# Eval("id_usuario") %>" title="Eliminar usuario" role="button" class="btn btn-danger btn-sm">Eliminar</a></td>
                        <td><%# Eval("nombre") %></td>
                        <td><%# Eval("ap_pat") %></td>
                        <td><%# Eval("ap_mat") %></td>
                        <td><%# Eval("email") %></td>
                        <td><%# Eval("phone") %></td>
                        <td><%# Eval("usu") %></td>
                        <td><%# Eval("pw") %></td>
                        <td><%# Eval("activo") %></td>
                    </tr>
                </ItemTemplate>

            </asp:ListView>
       
    </section>



</asp:Content>
