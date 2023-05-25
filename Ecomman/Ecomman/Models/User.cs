namespace Ecomman.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Address { get; set; }
    }
}
