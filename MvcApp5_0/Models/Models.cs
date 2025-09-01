namespace MvcApp5_0.Models
{
    public class Models
    {
        public record class Person1(int Id, string Name, int Age, Company Work);
        public record class Company(int Id, string Name, string Country);

    }
}
