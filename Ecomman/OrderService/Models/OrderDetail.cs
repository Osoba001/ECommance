namespace Ecomman.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public required string User { get; set; }
        public required string Name { get; set; }
        public required int Quantity { get; set; }
    }
}
