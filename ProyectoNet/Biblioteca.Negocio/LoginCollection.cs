using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class LoginCollection
    {
        public LoginCollection()
        { }

        private List<Biblioteca.Negocio.Login> GenerarListado(List<Biblioteca.DALC.Login> logDALC)
        {
            List<Biblioteca.Negocio.Login> login = new List<Login>();

            foreach (Biblioteca.DALC.Login item in logDALC)
            {
                Biblioteca.Negocio.Login loginTemporal = new Login();

                loginTemporal.IdUsuario = item.IdUsuario;
                loginTemporal.Password = item.Password;
                loginTemporal.Email = item.Email;

                login.Add(loginTemporal);
            }
            return login;
        }

        public List<Login> ReadAllLogin()
        {
            var login = CommonBC.ModeloCentroMedico.Login;
            return GenerarListado(login.ToList());
        }
    }
}
