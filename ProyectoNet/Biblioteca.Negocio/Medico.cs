using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class Medico
    {
        #region ---Atributos---
        private int id_medico;
        private int rut_medico;
        private string dv_medico;
        private string nombre_medico;
        private string apellido_medico;
        private string especialidad_medico;
        #endregion

        #region ---GET & SET---

        public int Id_medico
        {
            get
            {
                return id_medico;
            }

            set
            {
                id_medico = value;
            }
        }

        public int Rut_medico
        {
            get
            {
                return rut_medico;
            }

            set
            {
                rut_medico = value;
            }
        }

        public string Dv_medico
        {
            get
            {
                return dv_medico;
            }

            set
            {
                dv_medico = value;
            }
        }

        public string Nombre_medico
        {
            get
            {
                return nombre_medico;
            }

            set
            {
                nombre_medico = value;
            }
        }

        public string Apellido_medico
        {
            get
            {
                return apellido_medico;
            }

            set
            {
                apellido_medico = value;
            }
        }

        public string Especialidad_medico
        {
            get
            {
                return especialidad_medico;
            }

            set
            {
                especialidad_medico = value;
            }
        }
        #endregion

        #region ---Constructores---
        public Medico()
        {
            Init();
        }
        #endregion

        #region ---Metodos---
        public void Init()
        {
            this.id_medico = 0;
            this.rut_medico = 0;
            this.dv_medico = string.Empty;
            this.nombre_medico = string.Empty;
            this.apellido_medico = string.Empty;
            this.especialidad_medico = string.Empty;
        }

        public bool Create()
        {
            try
            {
                Biblioteca.DALC.Medico med = new DALC.Medico();

                med.id_medico = this.id_medico;
                med.rut_medico = this.rut_medico;
                med.dv_medico = this.dv_medico;
                med.nombre_medico = this.nombre_medico;
                med.apellido_medico = this.apellido_medico;
                med.especialidad_medico = this.especialidad_medico;

                CommonBC.ModeloCentroMedico.Medico.Add(med);
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
                Biblioteca.DALC.Medico med = 
                    CommonBC.ModeloCentroMedico.Medico.First
                    (
                        medic => medic.id_medico == this.id_medico
                        );

                med.rut_medico = this.rut_medico;
                med.dv_medico = this.dv_medico;
                med.nombre_medico = this.nombre_medico;
                med.apellido_medico = this.apellido_medico;
                med.especialidad_medico = this.especialidad_medico;

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
                Biblioteca.DALC.Medico med =
                    CommonBC.ModeloCentroMedico.Medico.First
                    (
                        medic => medic.id_medico == this.id_medico
                        );

                this.rut_medico = med.rut_medico;
                this.dv_medico = med.dv_medico;
                this.nombre_medico = med.nombre_medico;
                this.apellido_medico = med.apellido_medico;
                this.especialidad_medico = med.especialidad_medico;

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
                Biblioteca.DALC.Medico med =
                   CommonBC.ModeloCentroMedico.Medico.First
                   (
                       medic => medic.id_medico == this.id_medico
                       );

                CommonBC.ModeloCentroMedico.Medico.Remove(med);
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
