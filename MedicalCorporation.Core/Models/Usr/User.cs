using System;

namespace MedicalCorporation.Core.Models
{
    public class User : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.usr}.Users";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Sex Sex { get; set; }
        public DateTime? DateOfBirtf { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? DefaultTownId { get; set; }
    }

    public enum Sex : int
    {
        Male = 1,
        Female = 2,
    }
}
