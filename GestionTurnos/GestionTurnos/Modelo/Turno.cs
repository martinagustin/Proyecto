using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnos
{
    internal class Turno
    {
        public DateTime Fecha { get; set; }
        public Paciente Paciente { get; set; }
        public Profesional Profesional { get; set; }
        public Turno()
        {
            Fecha = DateTime.Now;
        }
    }
}
