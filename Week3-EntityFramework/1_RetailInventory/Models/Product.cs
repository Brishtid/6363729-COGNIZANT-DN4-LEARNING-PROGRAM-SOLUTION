namespace RetailInventory.Models
{
    public class Product
    {
        public int ProductId { get; set; }      //Brishti
        public string Name { get; set; }
        public int QuantityInStock { get; set; }

        // Foreign Key 6363729
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
