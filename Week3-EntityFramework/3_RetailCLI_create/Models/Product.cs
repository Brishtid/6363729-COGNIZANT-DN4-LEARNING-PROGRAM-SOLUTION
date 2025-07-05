namespace _3_RetailCLI.Models
{
    public class Product
    {
        //6363729
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        
        public int CategoryId { get; set; }

        
        public Category Category { get; set; }
    }
}
