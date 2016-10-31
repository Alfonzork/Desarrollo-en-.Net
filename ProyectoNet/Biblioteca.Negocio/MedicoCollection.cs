using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class MedicoCollection
    {
        public MedicoCollection()
        { }

        private List<Biblioteca.Negocio.Medico> GenerarListado
            (List<Biblioteca.DALC.Medico> medDALC)
        {
            List<Biblioteca.Negocio.Medico> medico = new List<Medico>();

            foreach (Biblioteca.DALC.Medico item in medDALC)
            {
                Biblioteca.Negocio.Medico medicoTemporal = new Medico();
                medicoTemporal.Id_medico = item.id_medico;
                medicoTemporal.Rut_medico = item.rut_medico;
                medicoTemporal.Dv_medico = item.dv_medico;
                medicoTemporal.Nombre_medico = item.nombre_medico;
                medicoTemporal.Apellido_medico = item.apellido_medico;
                medicoTemporal.Especialidad_medico = item.especialidad_medico;

                medico.Add(medicoTemporal);
            }

            return medico;
        }

        public List<Medico> ReadAllMedico()
        {
            var medicos = CommonBC.ModeloCentroMedico.Medico;
            return GenerarListado(medicos.ToList());
        }      
                    
    }
}

