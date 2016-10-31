using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Paciente
    {
        #region ---Atributos---
        private int id_ficha;
        private int rut_paciente;
        private string dv_paciente;
        private string nombre_paciente;
        private string apellido_paciente;
        #endregion

        #region ---GET & SET---
        public int Id_ficha
        {
            get
            {
                return id_ficha;
            }

            set
            {
                id_ficha = value;
            }
        }

        public int Rut_paciente
        {
            get
            {
                return rut_paciente;
            }

            set
            {
                rut_paciente = value;
            }
        }

        public string Dv_paciente
        {
            get
            {
                return dv_paciente;
            }

            set
            {
                dv_paciente = value;
            }
        }

        public string Nombre_paciente
        {
            get
            {
                return nombre_paciente;
            }

            set
            {
                nombre_paciente = value;
            }
        }

        public string Apellido_paciente
        {
            get
            {
                return apellido_paciente;
            }

            set
            {
                apellido_paciente = value;
            }
        }
        #endregion

        #region ---Constructores---
        public Paciente()
        {
            Init();
        }
        #endregion

        #region ---Metodos---
        public void Init()
        {
            this.Id_ficha = 0;
            this.Rut_paciente = 0;
            this.Dv_paciente = string.Empty;
            this.Nombre_paciente = string.Empty;
            this.Apellido_paciente = string.Empty;
        }

        public bool Create()
        {
            try
            {
                Biblioteca.DALC.FichaPaciente pac = new DALC.FichaPaciente();

                pac.id_ficha = this.Id_ficha;
                pac.rut_paciente = this.Rut_paciente;
                pac.dv_paciente = this.Dv_paciente;
                pac.nombre_paciente = this.Nombre_paciente;
                pac.apellido_paciente = this.Apellido_paciente;

                CommonBC.ModeloCentroMedico.FichaPaciente.Add(pac);
                CommonBC.ModeloCentroMedico.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Biblioteca.DALC.FichaPaciente pac =
                    CommonBC.ModeloCentroMedico.FichaPaciente.First
                    (
                        pacien => pacien.id_ficha == this.Id_ficha
                        );

                pac.rut_paciente = this.Rut_paciente;
                pac.dv_paciente = this.Dv_paciente;
                pac.nombre_paciente = this.Nombre_paciente;
                pac.apellido_paciente = this.Apellido_paciente;

                CommonBC.ModeloCentroMedico.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update()
        {
            try
            {
                Biblioteca.DALC.FichaPaciente pac =
                    CommonBC.ModeloCentroMedico.FichaPaciente.First
                    (
                        pacien => pacien.id_ficha == this.Id_ficha
                        );

                this.Rut_paciente = pac.rut_paciente;
                this.Dv_paciente = pac.dv_paciente;
                this.Nombre_paciente = pac.nombre_paciente;
                this.Apellido_paciente = pac.apellido_paciente;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                Biblioteca.DALC.FichaPaciente pac =
                   CommonBC.ModeloCentroMedico.FichaPaciente.First
                   (
                       pacien => pacien.id_ficha == this.Id_ficha
                       );

                CommonBC.ModeloCentroMedico.FichaPaciente.Remove(pac);
                CommonBC.ModeloCentroMedico.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
    }
}
