namespace AspDotNetCoreMvcDocker.Models
{
    public class Book
    {
        public Book() { }
        public Book(string name = null,
        string category = null,
        decimal price = 0)
        {
            Name = name;
            Category = category;
            Price = price;
        }
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}