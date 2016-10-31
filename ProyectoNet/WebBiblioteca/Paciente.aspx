<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="WebBiblioteca.Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            padding-bottom: 9px;
            margin: 40px 0 20px;
            border-bottom: 1px solid #eee;
            text-align: left;
        }
        .auto-style2 {
            width: 28px;
        }
        .auto-style3 {
            width: 85px;
        }
        .auto-style4 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style5 {
            width: 182px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-wrapper">
<table style="width:100%;">
    <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td><div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="auto-style1">
                            Paciente
                            <small>Fichas</small>
                        </h1>
                        <ol class="breadcrumb">
                            <li class="text-left">
                                <i class="fa fa-file"></i>  <a href="Sistema.aspx">Inicio</a>
                            </li>
                            <li class="active" style="text-align: left">
                                <i class="fa fa-user"></i> Paciente
                            </li>
                        </ol>
                <div class="panel panel-primary" style="width: 373px">
                    <div class ="panel-heading"><h3 class ="panel-title"> Ingreso Nuevos Pacientes</h3>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="auto-style4">
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblNFicha" class="auto-style3">N° Ficha</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="txtNFicha" runat="server" Width="161px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblRut" class="auto-style3">Rut</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="txtRutPac" runat="server" Width="161px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblDv" class="auto-style3">Dv</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="txtDvPac" runat="server" Width="161px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblNombre" class="auto-style3">Nombre</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="txtNombrePac" runat="server" Width="161px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblApellido" class="auto-style3">Apellido</td>
                            <td class="auto-style5">
                                <asp:TextBox ID="txtApellidoPac" runat="server" Width="161px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblApellido" class="auto-style3">&nbsp;</td>
                            <td class="auto-style5">
                                &nbsp;</td>
                            <td>
                    <asp:Button ID="btnGuardarPaciente" runat="server" OnClick="btnGuardarPaciente_Click" Text="Guardar" Width="94px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;</td>
                            <td id="lblApellido" colspan="2"><asp:Label ID="lblMensaje" runat="server"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </div>
                <div class="panel panel-success" style="width: 535px">
                    <div class ="panel-heading"><h3 class ="panel-title"> Listado de Pacientes</h3>
                    </div>
                    <asp:GridView ID="gvPacientes" runat="server" AutoGenerateColumns="False" DataKeyNames="rut_paciente" CellPadding="4" ForeColor="#333333" GridLines="None" Width="532px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="id_ficha" HeaderText="N° Ficha" InsertVisible="False" ReadOnly="True" SortExpression="id_ficha" />
                            <asp:BoundField DataField="rut_paciente" HeaderText="Rut" ReadOnly="True" SortExpression="rut_paciente" />
                            <asp:BoundField DataField="dv_paciente" HeaderText="Dv" SortExpression="dv_paciente" />
                            <asp:BoundField DataField="nombre_paciente" HeaderText="Nombre" SortExpression="nombre_paciente" />
                            <asp:BoundField DataField="apellido_paciente" HeaderText="Apellido" SortExpression="apellido_paciente" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Read" TypeName="Biblioteca.Negocio.Paciente"></asp:ObjectDataSource>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                    </div>
                </div>
                <!-- /.row -->

            </div>
            <!-- /.container-fluid -->
        </td>
        </tr>
    </table>
        </div>
        <!-- /#page-wrapper -->
    
</asp:Content>

 
                
                    
                
            