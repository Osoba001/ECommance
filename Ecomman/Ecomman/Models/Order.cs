namespace Ecomman.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required User User { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
