using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class LoginCollection
    {
        public LoginCollection()
        { }

        private List<CentroMedico.Negocio.Login> GenerarListado(List<CentroMedico.DALC.Login> logDALC)
        {
            List<CentroMedico.Negocio.Login> login = new List<Login>();

            foreach (CentroMedico.DALC.Login item in logDALC)
            {
                CentroMedico.Negocio.Login loginTemporal = new Login();

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
