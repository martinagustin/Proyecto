namespace GestionTurnos
{
    internal class Profesional : Persona
    {
        public int Matricula { get; set; }
        public List<FechaHoraAtencion> FechaHoraAtencion { get; set; }
        public List<string> Especialidades { get; set; }
    }
}
