using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Negocio;

namespace WebBiblioteca
{
    public partial class Paciente : System.Web.UI.Page
    {
        private Biblioteca.Negocio.BibliotecaCollection lista =
            new Biblioteca.Negocio.BibliotecaCollection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            gvPacientes.DataSource = lista.ReadAllPaciente();
            gvPacientes.DataBind();
        }

        private void LimpiaControles()
        {
            txtNFicha.Text = string.Empty;
            txtRutPac.Text = string.Empty;
            txtDvPac.Text = string.Empty;
            txtNombrePac.Text = string.Empty;
            txtApellidoPac.Text = string.Empty;
        }

        protected void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Biblioteca.Negocio.Paciente p = new Biblioteca.Negocio.Paciente();
                p.Id_ficha = int.Parse(txtNFicha.Text);

                if (!p.Read())
                {
                    p.Rut_paciente = int.Parse(txtRutPac.Text);

                    p.Dv_paciente = txtDvPac.Text;
                    p.Nombre_paciente = txtNombrePac.Text;
                    p.Apellido_paciente = txtApellidoPac.Text;

                    p.Create();
                    lblMensaje.Text = "¡Paciente Creado con Exito!";
                    LimpiaControles();
                }
                else
                {
                    lblMensaje.Text = "¡Paciente Ya Existe!";
                    LimpiaControles();
                }
            }
            catch (Exception)
            {
                lblMensaje.Text = "¡Error Volver Intentar...!";
                LimpiaControles();
            }
        }
        
    }
}