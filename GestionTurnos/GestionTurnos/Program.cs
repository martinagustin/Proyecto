using GestionTurnos;

var paciente = new Paciente()
{
    Apellido = "Tasso",
    Nombre = "Mateo",
    DNI = 1243214,
    Patologia = new List<string>() { "Dolor de cabeza", "Fiebre" },
    Telefono = 123
};

var profesional = new Profesional()
{
    Apellido = "Lucci",
    Nombre = "Gino",
    DNI = 41341414,
    Telefono = 123123,
    Matricula = 2222222,
    FechaHoraAtencion = new List<FechaHoraAtencion>()
    {
        new FechaHoraAtencion()
        {
            DiaSemana = (int)DayOfWeek.Monday,
            HoraDesde = Convert.ToDateTime("2000/01/01 10:00"),
            HoraHasta = Convert.ToDateTime("2000/01/01 12:00")
        },
        new FechaHoraAtencion()
        {
            DiaSemana = (int)DayOfWeek.Monday,
            HoraDesde = Convert.ToDateTime("2000/01/01 16:00"),
            HoraHasta = Convert.ToDateTime("2000/01/01 18:00")
        }
    }

};

var turno = new Turno()
{
    Paciente = paciente,
    Profesional = profesional
};
//Paciente
Console.WriteLine($"{paciente.Nombre} {paciente.Apellido}: \n DNI {paciente.DNI}");

//Profesional
Console.WriteLine($"{profesional.Nombre} {profesional.Apellido}: \n MATRICULA {profesional.Matricula}");
foreach (var fechaHora in profesional.FechaHoraAtencion)
    Console.WriteLine($"Lunes: Desde las {fechaHora.HoraDesde.Hour} hasta las {fechaHora.HoraHasta.Hour}");

//Turno
Console.WriteLine($"El paciente {turno.Paciente.Nombre} {turno.Paciente.Apellido} tiene un turno con el profesional {turno.Profesional.Nombre} {turno.Profesional.Apellido} el día {turno.Fecha}");

Console.ReadKey();