namespace MVCCrudWithDapper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? MiddleName { get; set; }
    }
}
