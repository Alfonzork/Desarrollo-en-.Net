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
                try
                {
                    if (value == ValidaRut(Rut_medico))
                    {
                        dv_medico = value;
                    }
                    
                }
                catch (Exception)
                {

                    throw new ArgumentException(string.Format("Rut No Valido..."));
                   
                }
                
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

                CommonBC.ModeloCentroMedico.SaveChanges();

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
                dv = "0";
            }
            else if (zz == 10)
            {
                dv = "K";
            }
            else { dv = zz.ToString(); }

            return dv;

        }
        #endregion
    }
}
