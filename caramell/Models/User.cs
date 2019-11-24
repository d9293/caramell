using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace caramell.Models
{
    public class User
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string FullName => $"{Surname} {Name} {MiddleName}";
        public string Login { get; set; }
        public int RoleId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Pwd { get; set; }
    }
}
