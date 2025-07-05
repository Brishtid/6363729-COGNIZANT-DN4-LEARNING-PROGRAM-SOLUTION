namespace RetailInventory.Models
{
    public class Category
    {
        public int CategoryId { get; set; }     // 6363729
        public string Name { get; set; }

        
        public List<Product> Products { get; set; } = new();
    }
}
