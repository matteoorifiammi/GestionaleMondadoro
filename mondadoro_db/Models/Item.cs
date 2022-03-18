namespace mondadoro_db.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal ListPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; } = string.Empty;
    }
}
