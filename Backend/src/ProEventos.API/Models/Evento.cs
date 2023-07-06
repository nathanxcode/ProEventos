namespace ProEventos.API.Models
{
    public class Evento
    {
        
        public int EventoId { get; set; }
        public string Name { get; set; }
        public string Palestrante { get; set; }
        public int CapacidadeEvento { get; set; }

    }
}