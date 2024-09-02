namespace EHA_Assignment_SAOnlineMart.Models
{
    public class CartItem
    {
        public int prodId { get; set; }
        public string prodName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public CartItem()
        {
            
        }
    }
}
