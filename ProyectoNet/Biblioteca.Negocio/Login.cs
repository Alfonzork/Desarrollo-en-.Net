using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class Login
    {
        #region --- Atributos ---
        private string _IdUsuario;
        private string _Password;
        private string _Email;
        #endregion

        #region --- GET & SET ---
        public string IdUsuario
        {
            get
            {
                return _IdUsuario;
            }

            set
            {
                _IdUsuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }
        #endregion

        #region --- Constructor ---
        public Login()
        {
            this.Init();
        }
        #endregion

        #region --- Metodos ---
        public void Init()
        {
            this._IdUsuario = string.Empty;
            this._Password = string.Empty;
            this._Email = string.Empty;
        }

        public bool Create()
        {
            try
            {
                Biblioteca.DALC.Login log = new DALC.Login();

                log.IdUsuario = this._IdUsuario;
                log.Password = this._Password;
                log.Email = this._Email;

                CommonBC.ModeloCentroMedico.Login.Add(log);
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
                Biblioteca.DALC.Login log =  CommonBC.ModeloCentroMedico.Login.First(logi => logi.IdUsuario == this.IdUsuario);

                log.IdUsuario = this._IdUsuario;
                log.Password = this._Password;
                log.Email = this._Email;

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
                Biblioteca.DALC.Login log = CommonBC.ModeloCentroMedico.Login.First(logi => logi.IdUsuario == this.IdUsuario);

                this._IdUsuario = log.IdUsuario;
                this._Password = log.Password;
                this._Email = log.Email;

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
                Biblioteca.DALC.Login log = CommonBC.ModeloCentroMedico.Login.First(logi => logi.IdUsuario == this.IdUsuario);

                CommonBC.ModeloCentroMedico.Login.Remove(log);
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
