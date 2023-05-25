namespace Ecomman.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Quantity { get; set; }
        public required Product Product { get; set; }
    }
}
