<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MantenedorUsuarios.aspx.cs" Inherits="WebCentroMedico.MantenedorUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 62px;
        }
        .auto-style2 {
            width: 66px;
        }
        .auto-style3 {
            width: 152px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-wrapper">
        <table style="width:100%;">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    <div class="container-fluid">

                <!-- Page Heading -->
                        <div class="row">
                            <div class="col-lg-6">
                                <h1 class="auto-style1">Usuarios <small>Registro</small> </h1>
                                <ol class="breadcrumb">
                                    <li class="text-left"><i class="fa fa-file"></i><a href="Sistema.aspx">Inicio</a> </li>
                                    <li class="active" style="text-align: left">Usuarios </li>
                                </ol>
                            </div>
                        </div>
                        <div class="panel panel-primary" style="width: 373px">
                            <div class ="panel-heading">
                                <h3 class ="panel-title">Ingreso Nuevos Usuarios</h3>
                            </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="auto-style4">
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td id="lblIdentificador" class="auto-style3">IdUsuario</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="txtIdUsuario" runat="server" Width="161px"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;&nbsp;</td>
                                    <td id="lblRut" class="auto-style3">Password</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="txtPassUsuario" runat="server" Width="161px" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td id="lblDv" class="auto-style3">Email</td>
                                    <td class="auto-style5">
                                        <asp:TextBox ID="txtEmailPass" runat="server" Width="161px" TextMode="Email"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td id="lblApellido0" class="auto-style3">&nbsp;</td>
                                    <td class="auto-style5">&nbsp;</td>
                                    <td>
                                        <asp:Button ID="btnGuardarMedico" runat="server" OnClick="btnGuardarPaciente_Click" Text="Guardar" Width="94px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td id="lblApellido1" colspan="2">
                                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                <!-- /.row -->
                        <div class="panel panel-success" style="width: 666px">
                            <div class ="panel-heading">
                                <h3 class ="panel-title">Listado de Usuarios</h3>
                            </div>
                            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="IdUsuario" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="665px" DataSourceID="ObjectDataSource1" >
                                <Columns>
                                    <asp:BoundField DataField="IdUsuario" HeaderText="IdUsuario" ReadOnly="True" SortExpression="IdUsuario" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                </Columns>
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
                        </div>
                    </div>
            <!-- /.container-fluid -->
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
        <!-- /#page-wrapper -->
    
</asp:Content>
