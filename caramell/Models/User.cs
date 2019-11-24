namespace caramell.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string FullName => $"{Surname} {Name} {MiddleName}";
        public string Login { get; set; }
        public int RoleId { get; set; }
    }
}
