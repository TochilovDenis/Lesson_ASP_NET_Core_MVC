namespace MvcApp5_0.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Parts Parts { get; set; }
        public Cars(int id, string name, Parts parts)
        {
            this.Id = id;
            this.Name = name;
            this.Parts = parts;
        }
    }
}
