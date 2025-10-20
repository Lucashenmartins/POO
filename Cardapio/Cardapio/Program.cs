

var TodosDias = new Disponibilidade
{
    DiasSemana = new List<int>
    {
        (int)DayOfWeek.Sunday,
        (int)DayOfWeek.Monday,
        (int)DayOfWeek.Tuesday,
        (int)DayOfWeek.Wednesday,
        (int)DayOfWeek.Thursday,
        (int)DayOfWeek.Friday,
        (int)DayOfWeek.Saturday
    },
    HoraInicio = new TimeSpan(0, 0, 0),
    HoraFim = new TimeSpan(23, 59, 59)
};

Console.WriteLine("Todos os dias:{0}", TodosDias.EstaDisponivel());