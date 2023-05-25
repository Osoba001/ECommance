namespace Ecomman.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public required Order Order { get; set; }
        public required Product Product { get; set; }
        public required int Quantity { get; set; }
    }
}
