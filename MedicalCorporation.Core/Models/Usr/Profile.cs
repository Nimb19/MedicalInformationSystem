namespace MedicalCorporation.Core.Models
{
    public class Profile : IHaveIdentifier
    {
        public static string TableName { get; } = $"{Scheme.usr}.Profiles";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? SalaryIncreasePerHour { get; set; }
        public int? RoleId { get; set; }
    }
}
