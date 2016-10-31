using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class CommonBC
    {
        private static CentroMedicoEntities _modeloCentroMedico;

        public static CentroMedicoEntities ModeloCentroMedico
        {
            get
            {
                if (_modeloCentroMedico == null)
                {
                    _modeloCentroMedico = new CentroMedicoEntities();
                }
                return _modeloCentroMedico;
            }

        }

        public CommonBC()
        {

        }
    }
}
