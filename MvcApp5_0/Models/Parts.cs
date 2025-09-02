namespace MvcApp5_0.Models
{
    public class Parts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public int Price { get; set; } 


        public Parts(int id, string name, string definition, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Definition = definition;
            this.Price = price; 
        }
    }
}
