public class Disponibilidade
    {
        public required List<int> DiasSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }

        public bool Disponivel { get; set; }
        public bool DisponivelForaHorario { get; set; }
        public DateTime DataAtualizacao { get; set; }
    
public bool EstaDisponivel()
    {
        if (DisponivelForaHorario)
            return true;

        var agora = DateTime.Now;

        foreach (int dia in DiasSemana)
        {
            if ((int)agora.DayOfWeek != dia)
                continue;
            if (agora.TimeOfDay >= HoraInicio && agora.TimeOfDay <= HoraFim)
                return true;
        }
         return false;  
         }
    }