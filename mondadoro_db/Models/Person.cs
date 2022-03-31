namespace mondadoro_db.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Sesso { get; set; } = string.Empty;
        public double Stipendio { get; set; }
        public int NumeroMatricola { get; set; }
    }
}
