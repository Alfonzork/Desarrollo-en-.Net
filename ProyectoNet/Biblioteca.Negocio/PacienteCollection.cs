using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class PacienteCollection
    {
        public PacienteCollection()
        { }

        private List<CentroMedico.Negocio.Paciente> GenLista(List<CentroMedico.DALC.Paciente> pacDALC)
        {
            List<CentroMedico.Negocio.Paciente> paciente = new List<Paciente>();

            foreach (CentroMedico.DALC.Paciente item in pacDALC)
            {
                CentroMedico.Negocio.Paciente pacienteTemporal = new Paciente();
                pacienteTemporal.Id_ficha = item.id_ficha;
                pacienteTemporal.Rut_paciente = item.rut_paciente;
                pacienteTemporal.Dv_paciente = item.dv_paciente;
                pacienteTemporal.Nombre_paciente = item.nombre_paciente;
                pacienteTemporal.Apellido_paciente = item.apellido_paciente;

                paciente.Add(pacienteTemporal);
            }
            return paciente;
        }

        public List<Paciente> ReadAllPaciente()
        {
            var pacientes = CommonBC.ModeloCentroMedico.Paciente;
            return GenLista(pacientes.ToList());
        }
    }
}
