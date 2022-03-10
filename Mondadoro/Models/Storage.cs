namespace Mondadoro.Models
{
    public class Storage
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string  Categoria { get; set; } = string.Empty;
        public decimal Prezzo { get; set; }
    }
}
