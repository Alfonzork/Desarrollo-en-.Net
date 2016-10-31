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
        private Biblioteca.Negocio.MedicoCollection listaMedico = 
            new Biblioteca.Negocio.MedicoCollection();

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

        private string ValidaRut(int rut)
        {
            int a, b, c, d, e, a1, b1, c1, d1, e1, f, f1, g, g1, h, yy, xx, zz;
            string dv;

            a = rut / 10000000;
            a1 = rut % 10000000;
            b = a1 / 1000000;
            b1 = a1 % 1000000;
            c = b1 / 100000;
            c1 = b1 % 100000;
            d = c1 / 10000;
            d1 = c1 % 10000;
            e = d1 / 1000;
            e1 = d1 % 1000;
            f = e1 / 100;
            f1 = e1 % 100;
            g = f1 / 10;
            g1 = f1 % 10;
            h = g1 / 1;

            yy = (h * 2) + (g * 3) + (f * 4) + (e * 5) + (d * 6) + (c * 7) + (b * 2) + (a * 3);
            xx = yy % 11;
            zz = 11 - xx;

            if (zz == 11)
            {
                dv =  "0";
            }
            else if (zz == 10)
            {
                dv = "K";
                }
            else { dv = zz.ToString(); }

            return dv;

        }

    }
}
