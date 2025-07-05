namespace _3_RetailCLI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //6363729
        public List<Product> Products { get; set; }
    }
}
