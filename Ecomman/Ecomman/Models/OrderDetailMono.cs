namespace Ecomman.Models
{
    public class OrderDetailMono
    {
        public int Id { get; set; }
        public required Order Order { get; set; }
        public required Product Product { get; set; }
        public required int Quantity { get; set; }
    }
    public class OrderDetail
    {
        public int Id { get; set; }
        public required string User { get; set; }
        public required string Name { get; set; }
        public required int Quantity { get; set; }
    }
}
