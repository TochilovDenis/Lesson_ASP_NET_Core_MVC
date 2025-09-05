using System.ComponentModel.DataAnnotations;

namespace MvcApp5_0.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public Parts parts { get; set; }

        // Конструктор без параметров (обязателен для привязки модели)
        public Cars() { }

        public Cars(int id, string name, Parts parts)
        {
            this.Id = id;
            this.Name = name;
            this.parts = parts;
        }
    }
}
