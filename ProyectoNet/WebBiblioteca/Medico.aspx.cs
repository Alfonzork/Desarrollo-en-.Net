using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBiblioteca
{
    public partial class Medico : System.Web.UI.Page
    {
        private Biblioteca.Negocio.BibliotecaCollection listaMedico = 
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
            gvMedicos.DataSource = listaMedico.ReadAllMedico();
            gvMedicos.DataBind();
        }

        private void LimpiaControles()
        {
            txtIdentificador.Text = string.Empty;
            txtRutMed.Text = string.Empty;
            txtDvMed.Text = string.Empty;
            txtNombreMed.Text = string.Empty;
            txtApellidoMed.Text = string.Empty;
            txtEspecialidad.Text = string.Empty;
        }

        protected void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                Biblioteca.Negocio.Medico m = new Biblioteca.Negocio.Medico();
                m.Id_medico = int.Parse(txtIdentificador.Text);

                if (!m.Read())
                {
                    m.Rut_medico = int.Parse(txtRutMed.Text);
                    m.Dv_medico = txtDvMed.Text;
                    m.Nombre_medico = txtNombreMed.Text;
                    m.Apellido_medico = txtApellidoMed.Text;
                    m.Especialidad_medico = txtEspecialidad.Text;

                    m.Create();
                    lblMensaje.Text = "¡Medico Creado con Exito!";
                    LimpiaControles();
                }
                else
                {
                    lblMensaje.Text = "¡Medico Ya Existe!";
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
